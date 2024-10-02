using EMS_BLL;
using EMS_BO;

namespace EMS_PL
{
    public partial class DepartmentAddForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;

        public DepartmentAddForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        Department department = new Department();

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void DepartmentAddForm_Load(object sender, EventArgs e)
        {
            LoadDepartmentData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            department.DepartmentName = departNameInput.Text;
        }

        private void LoadDepartmentData()
        {
            try
            {
                var departmentList = _departmentService.GetDepartmentStatistics();
                if (departmentList == null)
                {
                    MessageBox.Show("No department found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                employeesTable.AutoGenerateColumns = true;
                employeesTable.DataSource = departmentList;
                employeesTable.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading departments data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void budgetInput_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(budgetInput.Text, out decimal budget))
            {
                department.Budget = budget;
            }
            else
            {
                MessageBox.Show("Please enter a valid budget.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFormFields()
        {
            departNameInput.Text = string.Empty;
            budgetInput.Text = string.Empty;

            department = new Department();
        }
        //addbtn
        private void button8_Click(object sender, EventArgs e)
        {
            // Validate the form fields
            if (ValidateForm())
            {
                try
                {
                    _departmentService.CreateDepartment(department);
                    MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDepartmentData();
                    ClearFormFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validation function
        private bool ValidateForm()
        {
            // Check if Department Name is provided
            if (string.IsNullOrWhiteSpace(departNameInput.Text))
            {
                MessageBox.Show("Department name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if Budget is a valid decimal and non-negative
            if (!decimal.TryParse(budgetInput.Text, out decimal budget) || budget < 0)
            {
                MessageBox.Show("Please enter a valid budget. It must be a non-negative decimal value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Set department values after validation
            department.DepartmentName = departNameInput.Text;
            department.Budget = budget;

            // If everything is valid, return true
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // Update form
        private void button7_Click(object sender, EventArgs e)
        {
            DepartmentUpdateForm departmentUpdateForm = new DepartmentUpdateForm(_employeeService, _departmentService);
            departmentUpdateForm.ShowDialog();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // delete form
        private void button5_Click(object sender, EventArgs e)
        {
            DepartmentDeleteForm departmentDeleteForm = new DepartmentDeleteForm(_employeeService, _departmentService);
            departmentDeleteForm.ShowDialog();
            this.Hide();
        }
        // clear form
        private void button2_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void employeesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDepartmentData();
        }

        private void employeeHeadingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
