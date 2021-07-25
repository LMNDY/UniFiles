using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StackCalculator
{
    static class Program
    {

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IntStack stackA = new IntStack();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}