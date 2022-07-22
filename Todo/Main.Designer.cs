namespace Todo
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PN_Date = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PN_T1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Title2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Title3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Title4 = new System.Windows.Forms.Label();
            this.PN_Date.SuspendLayout();
            this.PN_T1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_Date
            // 
            this.PN_Date.Controls.Add(this.button1);
            this.PN_Date.Controls.Add(this.dateTimePicker1);
            this.PN_Date.Location = new System.Drawing.Point(2, 2);
            this.PN_Date.Name = "PN_Date";
            this.PN_Date.Size = new System.Drawing.Size(580, 35);
            this.PN_Date.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker1.Font = new System.Drawing.Font("서울남산 장체 M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.Date_Change);
            // 
            // PN_T1
            // 
            this.PN_T1.Controls.Add(this.dataGridView1);
            this.PN_T1.Controls.Add(this.Title1);
            this.PN_T1.Location = new System.Drawing.Point(2, 40);
            this.PN_T1.Name = "PN_T1";
            this.PN_T1.Size = new System.Drawing.Size(580, 150);
            this.PN_T1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(580, 135);
            this.dataGridView1.TabIndex = 1;
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("서울한강 장체 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title1.Location = new System.Drawing.Point(3, 3);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(56, 15);
            this.Title1.TabIndex = 0;
            this.Title1.Text = "오늘 할 일";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.Title2);
            this.panel1.Location = new System.Drawing.Point(2, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 150);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(580, 135);
            this.dataGridView2.TabIndex = 2;
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("서울한강 장체 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title2.Location = new System.Drawing.Point(3, 3);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(66, 15);
            this.Title2.TabIndex = 0;
            this.Title2.Text = "할 일 리스트";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.Title3);
            this.panel2.Location = new System.Drawing.Point(2, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 150);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 20);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(580, 135);
            this.dataGridView3.TabIndex = 2;
            // 
            // Title3
            // 
            this.Title3.AutoSize = true;
            this.Title3.Font = new System.Drawing.Font("서울한강 장체 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title3.Location = new System.Drawing.Point(3, 3);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(61, 15);
            this.Title3.TabIndex = 0;
            this.Title3.Text = "서류 리스트";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView4);
            this.panel3.Controls.Add(this.Title4);
            this.panel3.Location = new System.Drawing.Point(2, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 150);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 20);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(580, 135);
            this.dataGridView4.TabIndex = 2;
            // 
            // Title4
            // 
            this.Title4.AutoSize = true;
            this.Title4.Font = new System.Drawing.Font("서울한강 장체 M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title4.Location = new System.Drawing.Point(3, 3);
            this.Title4.Name = "Title4";
            this.Title4.Size = new System.Drawing.Size(61, 15);
            this.Title4.TabIndex = 0;
            this.Title4.Text = "구매 리스트";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PN_T1);
            this.Controls.Add(this.PN_Date);
            this.Name = "Main";
            this.Text = " Todo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PN_Date.ResumeLayout(false);
            this.PN_T1.ResumeLayout(false);
            this.PN_T1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PN_Date;
        private DateTimePicker dateTimePicker1;
        private Panel PN_T1;
        private Label Title1;
        private Panel panel1;
        private Label Title2;
        private Panel panel2;
        private Label Title3;
        private Panel panel3;
        private Label Title4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Button button1;
    }
}