using EMS_BLL;

namespace EMS_PL
{
    public partial class EmployeeViewform : Form
    {
        string searchTerm = "";
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;

        public EmployeeViewform(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }
        private void employeeHeadingLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadEmployeesData();
        }

        private void LoadEmployeesData()
        {
            try
            {
                var employeeList = _employeeService.GetAllEmployees();
                if (employeeList == null || !employeeList.Any())
                {
                    MessageBox.Show("No employees found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                employeesTable.AutoGenerateColumns = true;
                employeesTable.DataSource = employeeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeViewform_Load(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var searchResults = _employeeService.SearchEmployees(searchTerm);

                if (searchResults == null || !searchResults.Any())
                {
                    MessageBox.Show("No employees match your search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Populate the data grid with search results
                employeesTable.AutoGenerateColumns = true;
                employeesTable.DataSource = searchResults.ToList(); // Convert to list if needed for DataSource
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchPlaceholderInput_TextChanged(object sender, EventArgs e)
        {
            searchTerm = searchPlaceholderInput.Text;
        }
    }
}
