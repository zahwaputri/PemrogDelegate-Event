using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// NAMA : ZAHWA PUTRI CHAIRUNNISA
// NIM : 21.11.4084
// KELAS : 21 IF 04

namespace TugasCalculator
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
            Application.Run(new formCalculatorApp());
        }
    }
}