using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZingMP3_buildproject.Model;
using ZingMP3_buildproject.Model.Object;
using ZingMP3_buildproject.Control;


namespace ZingMP3_buildproject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.SingView());

        }
    }
}
