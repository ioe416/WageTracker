namespace WageTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.payDate = new System.Windows.Forms.DateTimePicker();
            this.gross_textBox = new System.Windows.Forms.TextBox();
            this.net_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(538, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // payDate
            // 
            this.payDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payDate.Location = new System.Drawing.Point(12, 12);
            this.payDate.Name = "payDate";
            this.payDate.Size = new System.Drawing.Size(83, 20);
            this.payDate.TabIndex = 1;
            // 
            // gross_textBox
            // 
            this.gross_textBox.Location = new System.Drawing.Point(101, 12);
            this.gross_textBox.Name = "gross_textBox";
            this.gross_textBox.Size = new System.Drawing.Size(67, 20);
            this.gross_textBox.TabIndex = 2;
            // 
            // net_textBox
            // 
            this.net_textBox.Location = new System.Drawing.Point(174, 12);
            this.net_textBox.Name = "net_textBox";
            this.net_textBox.Size = new System.Drawing.Size(67, 20);
            this.net_textBox.TabIndex = 3;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(247, 11);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(50, 23);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Save_Button_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.net_textBox);
            this.Controls.Add(this.gross_textBox);
            this.Controls.Add(this.payDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Wage Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker payDate;
        private System.Windows.Forms.TextBox gross_textBox;
        private System.Windows.Forms.TextBox net_textBox;
        private System.Windows.Forms.Button add_button;
    }
}

