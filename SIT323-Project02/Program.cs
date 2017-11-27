using System;
using System.Windows.Forms;

namespace SIT323_Project02
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                #region 
                // start application
                LogFile.WriteLogFile("Start Application");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainPage());
                #endregion
            }
            catch (Exception e)
            {
                LogFile.WriteLogFile("Error Entry : ----Exception----" + e.Message);
                //LogFile.WriteErrorFile("Error Entry : ----Exception----" + e.Message);
            }
        }


    }
}
