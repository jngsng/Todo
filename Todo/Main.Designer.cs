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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_Date = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CB_Date);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 30);
            this.panel1.TabIndex = 0;
            // 
            // CB_Date
            // 
            this.CB_Date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Date.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_Date.FormattingEnabled = true;
            this.CB_Date.Items.AddRange(new object[] {
            "22.07.18",
            "22.07.19"});
            this.CB_Date.Location = new System.Drawing.Point(0, 0);
            this.CB_Date.Name = "CB_Date";
            this.CB_Date.Size = new System.Drawing.Size(584, 33);
            this.CB_Date.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = " Todo";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox CB_Date;
    }
}