using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name;
        int price;
        int t;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                name = "Americano";
                int count = int.Parse(numericUpDown4.Value.ToString());
                price = 5;
                t = count * price;
                this.dataGridView1.Rows.Add(name, price+"$", count, t);
            }
            if (checkBox3.Checked)
            {
                name = "Mocha";
                int count = int.Parse(numericUpDown3.Value.ToString());
                price = 11;
                t = count * price;
                this.dataGridView1.Rows.Add(name, price+"$", count, t);
            }
            if (checkBox5.Checked)
            {
                name = "Latte";
                int count = int.Parse(numericUpDown5.Value.ToString());
                price = 8;
                t = count * price;
                this.dataGridView1.Rows.Add(name, price+"$", count, t);
            }
            if (checkBox10.Checked)
            {
                name = "Muffin";
                int count = int.Parse(numericUpDown9.Value.ToString());
                price = 3;
                t = count * price;
                this.dataGridView1.Rows.Add(name, price+"$", count, t);
            }
            if (checkBox9.Checked)
            {
                name = "Chesscake";
                int count = int.Parse(numericUpDown8.Value.ToString());
                price = 15;
                t = count * price;
                this.dataGridView1.Rows.Add(name, price+"$", count, t);
            }
            if (checkBox1.Checked)
            {
                name = "Espresso";
                int count = int.Parse(numericUpDown1.Value.ToString());
                price = 6;
                t = count * price;
                this.dataGridView1.Rows.Add(name, price + "$", count, t);
            }
            if (checkBox2.Checked)
            {
                name = "Cappuccino";
                int count = int.Parse(numericUpDown2.Value.ToString());
                price = 7;
                t = count * price;
                this.dataGridView1.Rows.Add(name, price + "$", count, t);
            }
            if (checkBox8.Checked)
            {
                name = "Doughnut";
                int count = int.Parse(numericUpDown10.Value.ToString());
                price = 5;
                t = count * price;
                this.dataGridView1.Rows.Add(name, price + "$", count, t);
            }

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }

            textBox1.Text = sum.ToString()+"$";
        }
    }
}

    
