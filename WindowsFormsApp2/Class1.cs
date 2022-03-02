using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1 : IComparable
    {
        string FIO;
        string MONTH;
        string YEAR;
        public Class1(string FIO, string month, string year)
        {
            this.FIO = FIO;
            this.YEAR = year;
            this.MONTH = month;
        }
        public string fio
        {
            get { return FIO; }
            set { FIO = value; }
        }
        public string month
        {
            get { return MONTH; }
            set { MONTH = value; }
        }
        public string year
        {
            get { return YEAR; }
            set { YEAR = value; }
        }
        public int CompareTo(object obj)
        {
            Class1 worker = (Class1)obj;
            return fio.CompareTo(worker.fio);
        }
    }
}
