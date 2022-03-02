using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ArrayList points;
        public Form1()
        {
            InitializeComponent();
            points = new ArrayList();
            res = new ArrayList();
        }
        ArrayList workers, res;

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            workers = new ArrayList(); //выделение памяти
            res = new ArrayList();
        }

  

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string month = textBox4.Text;
            string year = textBox3.Text;
            Class1 worker = new Class1(fio, month, year);
            workers.Add(worker);
            dataGridView1.Rows.Add(worker.fio, worker.month, worker.year);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            res.Sort();
            dataGridView2.Rows.Clear();
            foreach (Class1 worker in res)
                dataGridView2.Rows.Add(worker.fio, worker.month, worker.year);
        }
          

        private void button2_Click_1(object sender, EventArgs e)
        {
                
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            foreach (Class1 worker in workers)
                if ( 2022 - Convert.ToInt32(worker.year) >= 5)
                    res.Add(worker);
                
            foreach (Class1 worker in res)
            {
                workers.Remove(worker);
                //отображаем 2-й массив в таблице на форме
                dataGridView2.Rows.Add(worker.fio,worker.month,worker.year);
            }
            foreach (Class1 worker in workers)
                //отображаем 1-й массив в таблице на форме
                dataGridView1.Rows.Add(worker.fio, worker.month, worker.year);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string month = textBox4.Text;
            string year = textBox3.Text;
            Class1 worker = new Class1(fio, month, year);
            workers.Add(worker);
            dataGridView1.Rows.Add(worker.fio, worker.month, worker.year);
        }
    }
}

