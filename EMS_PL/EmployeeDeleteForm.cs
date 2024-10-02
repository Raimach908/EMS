using EMS_BLL;
using System;
using System.Windows.Forms;
using EMS_BO;

namespace EMS_PL
{
    public partial class EmployeeDeleteForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;
        Employee employee = new Employee();
        public EmployeeDeleteForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        private void empDeleteIdInput_TextChanged(object sender, EventArgs e)
        {
            //employee.EmployeeID = int.Parse(empDeleteIdInput.Text);
        }

        private void deleteButton_Click1(object sender, EventArgs e)
        {
            try
            {
                // Validate Employee ID input
                if (string.IsNullOrWhiteSpace(empDeleteIdInput.Text) || !int.TryParse(empDeleteIdInput.Text, out int employeeId))
                {
                    MessageBox.Show("Please enter a valid Employee ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No)
                {
                    return; // User cancelled the deletion
                }

                // Call the service to delete the employee by ID
                _employeeService.DeleteEmployee(employeeId);

                // Show a success message to the user
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the input field after successful deletion
                empDeleteIdInput.Text = string.Empty;
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs during the delete operation
                MessageBox.Show($"An error occurred while deleting the employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeDeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
