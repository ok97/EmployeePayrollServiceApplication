
namespace EmployeePayrollService
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Count = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.DataGridView();
            this.ctvalue = new System.Windows.Forms.Label();
            this.Submit1 = new EmployeePayrollService.RJButton();
            this.DeleteRecord = new EmployeePayrollService.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Count.Location = new System.Drawing.Point(42, 155);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(179, 25);
            this.Count.TabIndex = 3;
            this.Count.Text = "Employee Details";
            // 
            // Details
            // 
            this.Details.BackgroundColor = System.Drawing.Color.White;
            this.Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Details.Location = new System.Drawing.Point(12, 196);
            this.Details.Name = "Details";
            this.Details.RowHeadersWidth = 51;
            this.Details.RowTemplate.Height = 24;
            this.Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Details.Size = new System.Drawing.Size(1183, 384);
            this.Details.TabIndex = 4;
            this.Details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Details_CellClick);
            this.Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Details_CellContentClick);
            this.Details.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Details_CellDoubleClick);
            this.Details.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Details_CellMouseDoubleClick);
            // 
            // ctvalue
            // 
            this.ctvalue.AutoEllipsis = true;
            this.ctvalue.AutoSize = true;
            this.ctvalue.BackColor = System.Drawing.Color.YellowGreen;
            this.ctvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctvalue.ForeColor = System.Drawing.Color.White;
            this.ctvalue.Location = new System.Drawing.Point(246, 157);
            this.ctvalue.Name = "ctvalue";
            this.ctvalue.Size = new System.Drawing.Size(21, 24);
            this.ctvalue.TabIndex = 5;
            this.ctvalue.Text = "0";
            this.ctvalue.Click += new System.EventHandler(this.value_Click);
            // 
            // Submit1
            // 
            this.Submit1.BackColor = System.Drawing.Color.YellowGreen;
            this.Submit1.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.Submit1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Submit1.BorderRadius = 10;
            this.Submit1.BorderSize = 0;
            this.Submit1.FlatAppearance.BorderSize = 0;
            this.Submit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit1.ForeColor = System.Drawing.Color.White;
            this.Submit1.Location = new System.Drawing.Point(1027, 140);
            this.Submit1.Name = "Submit1";
            this.Submit1.Size = new System.Drawing.Size(145, 40);
            this.Submit1.TabIndex = 33;
            this.Submit1.Text = "AddEmployee";
            this.Submit1.TextColor = System.Drawing.Color.White;
            this.Submit1.UseVisualStyleBackColor = false;
            this.Submit1.Click += new System.EventHandler(this.Submit1_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.YellowGreen;
            this.DeleteRecord.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.DeleteRecord.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DeleteRecord.BorderRadius = 10;
            this.DeleteRecord.BorderSize = 0;
            this.DeleteRecord.FlatAppearance.BorderSize = 0;
            this.DeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRecord.ForeColor = System.Drawing.Color.White;
            this.DeleteRecord.Location = new System.Drawing.Point(850, 140);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(145, 40);
            this.DeleteRecord.TabIndex = 34;
            this.DeleteRecord.Text = "Delete";
            this.DeleteRecord.TextColor = System.Drawing.Color.White;
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 592);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.Submit1);
            this.Controls.Add(this.ctvalue);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePayrollService";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Count;
        public System.Windows.Forms.DataGridView Details;
        private System.Windows.Forms.Label ctvalue;
        private RJButton Submit1;
        private RJButton DeleteRecord;
    }
}