using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageTracker
{
    public partial class Form1 : Form
    {
        string conn_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joe\Documents\WageTracker.mdf;Integrated Security = True; Connect Timeout = 30";

        decimal sum = 0;
        decimal average = 0;
        decimal projected = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            Fill_DataGridView();
        }


        private void Fill_DataGridView()
        {

            if (dataGridView1.RowCount != 0)
            {
                //dataGridView1.ColumnCount = 6;
                decimal prevSum = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value.ToString());
                sum = prevSum + Convert.ToDecimal(gross_textBox.Text.ToString());
                average = sum / (dataGridView1.RowCount + 1);
                MessageBox.Show((dataGridView1.RowCount - 1).ToString());
                projected = (average * (52));

                dataGridView1.Rows.Add(new String[]
                {
                    payDate.Value.ToShortDateString(),
                    gross_textBox.Text,
                    net_textBox.Text,
                    sum.ToString(),
                    average.ToString(),
                    projected.ToString()
                });
            }
            else if (dataGridView1.RowCount == 0)
            {

                dataGridView1.Rows.Add(new String[]
                {
                    payDate.Value.ToShortDateString(),
                    gross_textBox.Text,
                    net_textBox.Text,
                    gross_textBox.Text,
                    gross_textBox.Text,
                    (Convert.ToDecimal(gross_textBox.Text.ToString())*52).ToString()
                });
            }
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

