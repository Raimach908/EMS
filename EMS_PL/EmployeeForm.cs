using EMS_BLL;
namespace EMS_PL
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;
        public EmployeeForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EmployeeAddForm employeeAddForm = new EmployeeAddForm(_employeeService, _departmentService);
            employeeAddForm.ShowDialog();
            this.Hide();
        }
        //update form
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeUpdateForm employeeUpdateForm = new EmployeeUpdateForm(_employeeService, _departmentService);
            employeeUpdateForm.ShowDialog();
            this.Hide();
        }
        //view form
        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeViewform employeeViewForm = new EmployeeViewform(_employeeService, _departmentService);
            employeeViewForm.ShowDialog();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            EmployeeDeleteForm employeeDeleteForm = new EmployeeDeleteForm(_employeeService, _departmentService);
            employeeDeleteForm.ShowDialog();
            this.Hide();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
