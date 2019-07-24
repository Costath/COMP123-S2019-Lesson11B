﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson11B
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void StudentInfoForm_Activated(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader inputStream = new StreamReader(File.Open("Student.txt", FileMode.Open)))
                {
                    int.Parse(inputStream.ReadLine());

                    // write stuff to the file
                    Program.student.id = int.Parse(inputStream.ReadLine());
                    Program.student.StudentID = int.Parse(inputStream.ReadLine());
                    Program.student.FirstName = int.Parse(inputStream.ReadLine());
                    Program.student.LastName = int.Parse(inputStream.ReadLine());

                    // cleanup
                    inputStream.Close();
                    inputStream.Dispose();

                    IDDataLabel.Text = Program.student.id.ToString();
                    StudentIDDataLabel.Text = Program.student.StudentID.ToString();
                    FirstNameDataLabel.Text = Program.student.FirstName.ToString();
                    LastNameDataLabel.Text = Program.student.LastName.ToString();

                }
            }
            catch (IOException exception)
            {

                MessageBox.Show("Error: " + exception.Message, "File I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void StudentInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
