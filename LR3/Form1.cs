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


        private void DelButton_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int num = dataGridView1.SelectedRows[0].Index;
                    Students.RemoveAt(num);
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
                catch
                {
                    MessageBox.Show("Выберите строку!!!!!!!!!!");
                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            res.Clear();
            dataGridView2.Rows.Clear();
            foreach (Student student in Students)//kek
            {

                if (student.Pos()>2)
                    dataGridView2.Rows.Add(student.name, student.bd, student.sec, student.psy, student.pe, student.code);
            }
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
