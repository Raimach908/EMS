using EMS_BLL;
using EMS_DAL;
using EMS_PL;
using Microsoft.Extensions.DependencyInjection;

namespace EMS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application (optional but common for WinForms)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IEmployeeRepository>(new EmployeeRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMS;Integrated Security=True;"))
                .AddSingleton<IDepartmentRepository>(new DepartmentRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMS;Integrated Security=True;"))
                .AddSingleton<EmployeeService>()
                .AddSingleton<DepartmentService>()
                .AddSingleton<Main_Form>()  
                .BuildServiceProvider();

            var mainForm = serviceProvider.GetService<Main_Form>();

            if (mainForm != null)
            {
                Application.Run(mainForm);
            }
            else
            {
                MessageBox.Show("Error: MainForm could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
