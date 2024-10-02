using EMS_BLL;

namespace EMS_PL
{
    public partial class Main_Form : Form
    {
        private string UserName { get; set; } = string.Empty;
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;
        public Main_Form(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            UserName = nameInput.Text;

            if (string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("Please enter your name!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Return to stop execution, so the form stays active
            }

            Dashboard dashboardForm = new Dashboard(_employeeService, _departmentService)
            {
                UserName = UserName
            };

            dashboardForm.ShowDialog();

            this.Hide();
        }
    }
}
