using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    internal class Student
    {
        string Name;
        int BD;
        int Sec;
        int Psychology;
        int PE;
        int Coding;
        //конструктор класса
        public Student(string Name, int BD, int Sec, int Psychology,int PE, int Coding)
        {
            this.Name = Name;
            this.BD = BD;
            this.Sec = Sec;
            this.Psychology = Psychology;
            this.PE = PE;
            this.Coding = Coding;
        }
        //доступы
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int bd
        {
            get { return BD; }
            set { BD = value; }
        }
        public int sec
        {
            get { return Sec; }
            set { Sec = value; }
        }
        public int psy
        {
            get { return Psychology; }
            set { Psychology = value; }
        }
        public int pe
        {
            get { return PE; }
            set { PE = value; }
        }
        public int code
        {
            get { return Coding; }
            set { Coding = value; }
        }
        
    }
}
