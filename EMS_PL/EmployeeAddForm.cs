using EMS_BLL;
using EMS_BO;
using System;
using System.Windows.Forms;

namespace EMS_PL
{
    public partial class EmployeeAddForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;

        public EmployeeAddForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        Employee employee = new Employee();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void departmentNameInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(departmentIdInput.Text) && int.TryParse(departmentIdInput.Text, out int departmentId))
            {
                employee.DepartmentID = departmentId;
            }
            else
            {
                employee.DepartmentID = 0; // Reset if the input is not valid or empty
            }
        }
        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            
        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {
            employee.FirstName = firstNameInput.Text;
        }

        private void lastNameInput_TextChanged(object sender, EventArgs e)
        {
            employee.LastName = lastNameInput.Text;
        }

        private void positionInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee.Position = positionInput.SelectedItem?.ToString(); // Handle selection
        }

        private void salaryInput_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(salaryInput.Text, out decimal salary))
            {
                employee.Salary = salary;
            }
            else
            {
                employee.Salary = 0; // Reset if not valid
            }
        }

        private void departmentIdInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(departmentIdInput.Text, out int departmentId))
            {
                employee.DepartmentID = departmentId;
            }
            else
            {
                employee.DepartmentID = 0; // Reset if not valid
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Validate the form fields
            if (ValidateForm())
            {
                try
                {
                    _employeeService.CreateEmployee(employee);
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
            {
                MessageBox.Show("First Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(employee.LastName))
            {
                MessageBox.Show("Last Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(employee.Position))
            {
                MessageBox.Show("Position must be selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (employee.Salary <= 0)
            {
                MessageBox.Show("Salary must be a valid number greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (employee.DepartmentID <= 0)
            {
                MessageBox.Show("Department ID must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed
        }

        private void ClearFormFields()
        {
            firstNameInput.Text = string.Empty;
            lastNameInput.Text = string.Empty;
            positionInput.SelectedIndex = -1; // Reset dropdown selection
            salaryInput.Text = string.Empty;
            departmentIdInput.Text = string.Empty;

            employee = new Employee(); // Reset employee object
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            EmployeeUpdateForm employeeUpdate = new EmployeeUpdateForm(_employeeService, _departmentService);
            employeeUpdate.ShowDialog();
            employeeUpdate.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            EmployeeDeleteForm employeeDeleteForm = new EmployeeDeleteForm(_employeeService, _departmentService);
            employeeDeleteForm.ShowDialog();
            this.Hide();
        }
    }
}
