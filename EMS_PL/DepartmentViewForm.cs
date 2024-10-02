using EMS_BLL;

namespace EMS_PL
{
    public partial class DepartmentViewForm : Form
    {
        string searchTerm = "";
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;

        public DepartmentViewForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        private void searchPlaceholderInput_TextChanged(object sender, EventArgs e)
        {
            searchTerm = searchPlaceholderInput.Text;
        }
        private void employeesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDepartmentData();
        }

        private void LoadDepartmentData()
        {
            try
            {
                var employeeList = _departmentService.GetDepartmentStatistics();
                if (employeeList == null || !employeeList.Any())
                {
                    MessageBox.Show("No department found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DepartmentViewForm_Load(object sender, EventArgs e)
        {
            LoadDepartmentData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that the search term is not empty
                if (string.IsNullOrWhiteSpace(searchPlaceholderInput.Text))
                {
                    MessageBox.Show("Please enter a department ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate that the search term contains only numeric input
                if (!searchPlaceholderInput.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Only numeric input is allowed for the department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convert the search term to an integer
                if (!int.TryParse(searchPlaceholderInput.Text, out int departmentId))
                {
                    MessageBox.Show("Please enter a valid numeric department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Perform search
                var searchResults = _departmentService.SearchDepartmentById(departmentId);

                if (searchResults == null || !searchResults.Any())
                {
                    MessageBox.Show("No department matches your search.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Populate the data grid with search results
                employeesTable.AutoGenerateColumns = true;
                employeesTable.DataSource = searchResults.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
