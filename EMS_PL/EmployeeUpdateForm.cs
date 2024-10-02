using EMS_BLL;
using EMS_BO;
using System;
using System.Windows.Forms;

namespace EMS_PL
{
    public partial class EmployeeUpdateForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;

        public EmployeeUpdateForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        Employee employee = new Employee();

        private void label2_Click(object sender, EventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
        private void departmentNameInput_TextChanged(object sender, EventArgs e)
        {
            employee.DepartmentID = int.Parse(departmentIdInput.Text);
        }
        private void CRUD_Load(object sender, EventArgs e)
        {
           
        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {
            employee.FirstName = firstNameInput.Text;
        }

        private void positionInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee.Position = positionInput.Text;
        }

        private void lastNameInput_TextChanged(object sender, EventArgs e)
        {
            employee.LastName = lastNameInput.Text;
        }

        private void salaryInput_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(salaryInput.Text, out decimal salary))
            {
                employee.Salary = salary;
            }
            else
            {
                MessageBox.Show("Please enter a valid salary amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                salaryInput.Focus();
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
                MessageBox.Show("Please enter a valid department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                departmentIdInput.Focus();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EmployeeAddForm employeeForm = new EmployeeAddForm(_employeeService, _departmentService);
            employeeForm.ShowDialog();
            this.Close();
        }

        private void ClearFormFields()
        {
            firstNameInput.Text = string.Empty;
            lastNameInput.Text = string.Empty;
            positionInput.SelectedIndex = -1; // Assuming it's a dropdown
            salaryInput.Text = string.Empty;
            departmentIdInput.Text = string.Empty;

            employee = new Employee();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateEmployeeForm())
            {
                try
                {
                    _employeeService.UpdateEmployee(employee);

                    // If successful, show a success message
                    MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            EmployeeDeleteForm employeeDeleteForm = new EmployeeDeleteForm(_employeeService, _departmentService);
            employeeDeleteForm.ShowDialog();
            this.Close();
        }

        private void firstNameLabel_Click(object sender, EventArgs e) { }

        private void updateIdlabel_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void empUpdateIdInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(empUpdateIdInput.Text, out int employeeId))
            {
                employee.EmployeeID = employeeId;
            }
            else
            {
                MessageBox.Show("Please enter a valid Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                empUpdateIdInput.Focus();
            }
        }

        private bool ValidateEmployeeForm()
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstNameInput.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(employee.LastName))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastNameInput.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(employee.Position))
            {
                MessageBox.Show("Position is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                positionInput.Focus();
                return false;
            }

            if (employee.Salary <= 0)
            {
                MessageBox.Show("Please enter a valid salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                salaryInput.Focus();
                return false;
            }

            if (employee.DepartmentID <= 0)
            {
                MessageBox.Show("Please enter a valid department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                departmentIdInput.Focus();
                return false;
            }

            return true;
        }
    }
}
