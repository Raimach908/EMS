using EMS_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_PL
{
    public partial class DepartmentForm : Form
    {
        private readonly EmployeeService _employeeService;
        private readonly DepartmentService _departmentService;
        public DepartmentForm(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            DepartmentAddForm departmentAddForm = new DepartmentAddForm(_employeeService, _departmentService);
            departmentAddForm.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartmentUpdateForm departmentUpdateForm = new DepartmentUpdateForm(_employeeService, _departmentService);
            departmentUpdateForm.ShowDialog();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DepartmentDeleteForm departmentDeleteForm = new DepartmentDeleteForm(_employeeService, _departmentService);
            departmentDeleteForm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepartmentViewForm departmentViewForm = new DepartmentViewForm(_employeeService, _departmentService);
            departmentViewForm.ShowDialog();
            this.Hide();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
