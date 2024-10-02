using EMS_BO;
using EMS_BLL;

namespace EMS_PL
{
    public partial class DepartmentUpdateForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;

        public DepartmentUpdateForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        Department department = new Department();

        private void departNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void DepartmentUpdateForm_Load(object sender, EventArgs e)
        {
            
        }

        // Clear form fields
        private void ClearFormFields()
        {
            textBox1.Text = string.Empty;
            departNameInput.Text = string.Empty;
            budgetInput.Text = string.Empty;

            department = new Department();
        }

        // Validate Department ID
        private bool ValidateDepartmentID()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || !int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Validate Department Name
        private bool ValidateDepartmentName()
        {
            if (string.IsNullOrEmpty(departNameInput.Text))
            {
                MessageBox.Show("Department Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Validate Budget
        private bool ValidateBudget()
        {
            if (string.IsNullOrEmpty(budgetInput.Text) || !decimal.TryParse(budgetInput.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric value for the budget.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Add form
        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentAddForm departmentAddForm = new DepartmentAddForm(_employeeService, _departmentService);
            departmentAddForm.ShowDialog();
            this.Hide();
        }

        // Update form
        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateDepartmentID() && ValidateDepartmentName() && ValidateBudget())
            {
                // Proceed with update only if all fields are valid
                _departmentService.UpdateDepartment(department);
                MessageBox.Show("Department updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Delete form
        private void button1_Click(object sender, EventArgs e)
        {
            DepartmentDeleteForm departmentDeleteForm = new DepartmentDeleteForm(_employeeService, _departmentService);
            departmentDeleteForm.ShowDialog();
            this.Hide();
        }

        // Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }
        // Update Department ID when text changes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int departmentID))
            {
                department.DepartmentID = departmentID;
            }
        }

        // Update Department Name when selected
        private void departNameInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            department.DepartmentName = departNameInput.Text;
        }

        // Update Budget when text changes
        private void budgetInput_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(budgetInput.Text, out decimal budget))
            {
                department.Budget = budget;
            }
        }

        // Reload department data when employees table is clicked
        private void employeesTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
