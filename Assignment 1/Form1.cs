using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        DataTable data=new DataTable();
        public Form1()
        {
            InitializeComponent();
            table.DataSource = data;
            data.Columns.Add("Name");
            data.Columns.Add("Cnic");
            data.Columns.Add("Rollno");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            DataRow row1 = data.NewRow();
            row1["Name"] = textBox1.Text;
            row1["Cnic"] = textBox2.Text;
            row1["Rollno"] = textBox3.Text;
            data.Rows.Add(row1);
            table.Refresh();
        }
    }
}
