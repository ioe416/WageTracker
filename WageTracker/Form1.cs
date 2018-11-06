using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace WageTracker
{
    public partial class Form1 : Form
    {
        decimal sum = 0;
        decimal average = 0;
        decimal projected = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void WageList_Populate()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("wagelist.txt");
            //string[] columnnames = ["Payday,Gross Pay,Net Pay,Y-T-D,Weekly Average,Projected Annual"];//file.ReadLine().Split(',');
            DataTable dt = new DataTable();

            dt.Columns.Add("Payday");
            dt.Columns.Add("Gross Pay", typeof(double));
            dt.Columns.Add("Net Pay", typeof(double));
            dt.Columns.Add("Y-T-D", typeof(double));
            dt.Columns.Add("Weekly Average", typeof(double));
            dt.Columns.Add("Projected Annual", typeof(double));
            //foreach (string c in columnnames)
            //{
            //    dt.Columns.Add(c);
            //}
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = newline.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    dr["Payday"] = values[0];
                    dr["Gross Pay"] = values[1];
                    dr["Net Pay"] = values[2];
                    dr["Y-T-D"] = values[3];
                    dr["Weekly Average"] = values[4];
                    dr["Projected Annual"] = values[5];
                }
                dt.Rows.Add(dr);
                
            }
            file.Close();

            dataGridView1.DataSource = dt;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "Payday";
            dataGridView1.Columns[0].DefaultCellStyle.Format = "d";
            dataGridView1.Columns[1].DataPropertyName = "Gross Pay";
            dataGridView1.Columns[1].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[2].DataPropertyName = "Net Pay";
            dataGridView1.Columns[2].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[3].DataPropertyName = "Y-T-D";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[4].DataPropertyName = "Weekly Average";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[5].DataPropertyName = "Projected Annual";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "c2";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WageList_Populate();
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            Add_To_DataGridView();
        }


        private void Add_To_DataGridView()
        {

            if (dataGridView1.RowCount != 0)
            {
                decimal prevSum = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value.ToString());
                sum = prevSum + Convert.ToDecimal(gross_textBox.Text.ToString());
                average = sum / (dataGridView1.RowCount + 1);
                projected = (average * (52));

                StreamWriter writer = new StreamWriter("wagelist.txt", true);

                string line = payDate.Text + "," + gross_textBox.Text + "," + net_textBox.Text + "," + sum.ToString() + "," + average.ToString() + "," + projected.ToString();
                writer.WriteLine(line);
                writer.Close();

                WageList_Populate();

            }
            else if (dataGridView1.RowCount == 0)
            {
                StreamWriter writer = new StreamWriter("wagelist.txt", true);

                string line = payDate.Text + "," + gross_textBox.Text + "," + net_textBox.Text + "," + gross_textBox.Text + "," + gross_textBox.Text + "," + (Convert.ToDecimal(gross_textBox.Text.ToString()) * 52).ToString();
                writer.WriteLine(line);
                writer.Close();
                WageList_Populate();

            }
            gross_textBox.Clear();
            net_textBox.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

