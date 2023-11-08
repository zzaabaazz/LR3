using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LR3
{
    public partial class Form1 : Form
    {
        ArrayList Students, res;
        public Form1()
        {
            InitializeComponent();
            
            Students = new ArrayList();
            res = new ArrayList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            int BD = (int)numericUpDown1.Value;
            int Sec = (int)numericUpDown2.Value;
            int Psychology = (int)numericUpDown3.Value;
            int PE = (int)numericUpDown4.Value;
            int Coding = (int)numericUpDown5.Value;
            Student student = new Student(Name, BD, Sec, Psychology, PE, Coding);
            Students.Add(student);
            dataGridView1.Rows.Add(Name, BD, Sec, Psychology, PE, Coding);
        }
    }
}
