using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private DataTable dataTable = new DataTable();
        void LoadDataGridView()
        {
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("First Name", typeof(String));
            dataTable.Columns.Add("Last Name", typeof(String));
            dataTable.Columns.Add("MahNum", typeof(int));

            dataGridView1.DataSource = dataTable;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataTable.Rows.Add(textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
