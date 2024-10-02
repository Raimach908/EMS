using EMS_BLL;
using EMS_BO;

namespace EMS_PL
{
    public partial class DepartmentDeleteForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;

        public DepartmentDeleteForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        Department department = new Department();

        // Validate Department ID
        private bool ValidateDepartmentID()
        {
            if (string.IsNullOrEmpty(empDeleteIdInput.Text) || !int.TryParse(empDeleteIdInput.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric Department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void empDeleteIdInput_TextChanged(object sender, EventArgs e)
        {
            // Only update DepartmentID if the input is a valid integer
            if (int.TryParse(empDeleteIdInput.Text, out int departmentID))
            {
                department.DepartmentID = departmentID;
            }
        }

        private void DepartmentDeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ValidateDepartmentID()) // Validate before deleting
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    _departmentService.DeleteDepartment(department.DepartmentID);
                    MessageBox.Show("Department deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields(); // Clear fields after successful deletion
                }
            }
        }

        // Clear form fields after deletion
        private void ClearFormFields()
        {
            empDeleteIdInput.Text = string.Empty;
            department = new Department();
        }
    }
}
