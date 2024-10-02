////using EMS_BLL;
////using EMS_DAL;
////using EMS_PL;
////using Microsoft.Extensions.DependencyInjection;

////namespace EMS
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            // Dependency Injection
////            var serviceProvider = new ServiceCollection()
////                .AddSingleton<IEmployeeRepository>(new EmployeeRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMS;Integrated Security=True;"))
////                .AddSingleton<IDepartmentRepository>(new DepartmentRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMS;Integrated Security=True;"))
////                .AddSingleton<EmployeeService>()
////                .AddSingleton<DepartmentService>()
////                .AddSingleton<MainForm>()
////                .BuildServiceProvider();

////            var consoleUI = serviceProvider.GetService<MainForm>();
////            //consoleUI.DisplayMenu();
////        }
////    }
////}
//using EMS_BLL;
//using EMS_DAL;
//using EMS_PL;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Windows.Forms;

//namespace EMS
//{
//    static class Program
//    {
//        [STAThread] // Required for Windows Forms applications
//        static void Main()
//        {
//            // Enable visual styles for the application (optional but common for WinForms)
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);

//            // Dependency Injection
//            var serviceProvider = new ServiceCollection()
//                .AddSingleton<IEmployeeRepository>(new EmployeeRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMS;Integrated Security=True;"))
//                .AddSingleton<IDepartmentRepository>(new DepartmentRepository("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EMS;Integrated Security=True;"))
//                .AddSingleton<EmployeeService>()
//                .AddSingleton<DepartmentService>()
//                .AddSingleton<MainForm>()  // Add MainForm to DI
//                .BuildServiceProvider();

//            // Get MainForm instance from the service provider
//            var mainForm = serviceProvider.GetService<MainForm>();

//            // Start the Windows Forms application with the MainForm
//            if (mainForm != null)
//            {
//                Application.Run(mainForm);
//            }
//            else
//            {
//                MessageBox.Show("Error: MainForm could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}
