namespace P2214201
{
    partial class Query_Interval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query_Interval));
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnVacuumDemAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(24, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(131, 30);
            this.dtpStart.TabIndex = 15;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(24, 79);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(131, 30);
            this.dtpEnd.TabIndex = 16;
            // 
            // btnVacuumDemAdd
            // 
            this.btnVacuumDemAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnVacuumDemAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVacuumDemAdd.FlatAppearance.BorderSize = 0;
            this.btnVacuumDemAdd.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVacuumDemAdd.ForeColor = System.Drawing.Color.Cyan;
            this.btnVacuumDemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnVacuumDemAdd.Image")));
            this.btnVacuumDemAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVacuumDemAdd.Location = new System.Drawing.Point(187, 35);
            this.btnVacuumDemAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVacuumDemAdd.Name = "btnVacuumDemAdd";
            this.btnVacuumDemAdd.Size = new System.Drawing.Size(57, 57);
            this.btnVacuumDemAdd.TabIndex = 39;
            this.btnVacuumDemAdd.Text = "查詢";
            this.btnVacuumDemAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVacuumDemAdd.UseVisualStyleBackColor = false;
            this.btnVacuumDemAdd.Click += new System.EventHandler(this.btnVacuumDemAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "      ";
            // 
            // Query_Interval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(272, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVacuumDemAdd);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Query_Interval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查詢區間";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnVacuumDemAdd;
        private System.Windows.Forms.Label label1;
    }
}