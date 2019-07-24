using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson11B
{
    public static class Program
    {
        public static Student student;
        public static StartForm startForm;
        public static MainForm mainForm;
        public static AboutForm aboutBox;
        public static StudentInfoForm studentInfoForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            student = new Student();
            studentInfoForm = new StudentInfoForm();

            startForm = new StartForm();
            mainForm = new MainForm();
            aboutBox = new AboutForm();

            Application.Run(startForm);


        }
    }
}
