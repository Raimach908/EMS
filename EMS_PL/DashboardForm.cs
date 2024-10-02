using EMS_BLL;
using EMS_BO;

namespace EMS_PL
{
    public partial class Dashboard : Form
    {
        public string UserName { get; set; }
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;
        public Dashboard(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserName))
            {
                welcome.Text = $"Welcome, {UserName}!";
            }
        }

        private void ems_icon_Click(object sender, EventArgs e)
        {

        }

        private void dashboardNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            DepartmentForm employeeForm = new DepartmentForm(_employeeService, _departmentService);
            employeeForm.ShowDialog();
            this.Close();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(_employeeService, _departmentService);
            employeeForm.ShowDialog();
            this.Close();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void salaryButton_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
