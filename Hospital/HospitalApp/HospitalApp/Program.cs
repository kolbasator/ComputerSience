using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalLibrary;
namespace HospitalApp
{
    static class Program
    {
        public static SignIn Sign = new SignIn();
        public static Hospital FirstHospital;

       
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();

            Application.Run(Program.Sign);
            
        }
    }
}
