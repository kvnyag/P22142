namespace P2214201
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("人員基本資料");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("廠房基本資料");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("類別基本資料");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("單位機械編號資料");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("檢查項目資料");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("基本資料作業", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("真空機運轉記錄表");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("空壓機運轉記錄表");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("冷氣運轉記錄表");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("水電運轉記錄表");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("巡檢表資料建立", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("查詢真空機巡檢記錄");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("查詢空壓機巡檢記錄");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("查詢冷氣巡檢記錄");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("查詢水電巡檢記錄");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("查詢作業", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("傳輸資料");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("傳輸作業", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("設定");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("離開");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbxLoginRole = new System.Windows.Forms.TextBox();
            this.tbxLoginAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trvSelectFn = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Turquoise;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.tbxLoginRole);
            this.splitContainer1.Panel1.Controls.Add(this.tbxLoginAccount);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.trvSelectFn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer1.Size = new System.Drawing.Size(1034, 696);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbxLoginRole
            // 
            this.tbxLoginRole.Location = new System.Drawing.Point(112, 625);
            this.tbxLoginRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxLoginRole.Name = "tbxLoginRole";
            this.tbxLoginRole.Size = new System.Drawing.Size(87, 22);
            this.tbxLoginRole.TabIndex = 6;
            // 
            // tbxLoginAccount
            // 
            this.tbxLoginAccount.Location = new System.Drawing.Point(112, 601);
            this.tbxLoginAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxLoginAccount.Name = "tbxLoginAccount";
            this.tbxLoginAccount.Size = new System.Drawing.Size(87, 22);
            this.tbxLoginAccount.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 631);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "登入權限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 609);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "登入帳號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "國巨巡檢系統";
            // 
            // trvSelectFn
            // 
            this.trvSelectFn.BackColor = System.Drawing.Color.Teal;
            this.trvSelectFn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvSelectFn.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.trvSelectFn.ForeColor = System.Drawing.Color.LimeGreen;
            this.trvSelectFn.Location = new System.Drawing.Point(15, 52);
            this.trvSelectFn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trvSelectFn.Name = "trvSelectFn";
            treeNode1.Name = "StaffInfo";
            treeNode1.Text = "人員基本資料";
            treeNode2.Name = "FactoryInfo";
            treeNode2.Text = "廠房基本資料";
            treeNode3.Name = "ReportInfo";
            treeNode3.Text = "類別基本資料";
            treeNode4.Name = "MachineInfo";
            treeNode4.Text = "單位機械編號資料";
            treeNode5.Name = "CheckInfo";
            treeNode5.Text = "檢查項目資料";
            treeNode6.Name = "BaseInfo";
            treeNode6.Text = "基本資料作業";
            treeNode7.Name = "VacuumRep";
            treeNode7.Text = "真空機運轉記錄表";
            treeNode8.Name = "CompressRep";
            treeNode8.Text = "空壓機運轉記錄表";
            treeNode9.Name = "AirConditionRep";
            treeNode9.Text = "冷氣運轉記錄表";
            treeNode10.Name = "HydropowerRep";
            treeNode10.Text = "水電運轉記錄表";
            treeNode11.Name = "ReportBuild";
            treeNode11.Text = "巡檢表資料建立";
            treeNode12.Name = "VacuumDem";
            treeNode12.Text = "查詢真空機巡檢記錄";
            treeNode13.Name = "CompressDem";
            treeNode13.Text = "查詢空壓機巡檢記錄";
            treeNode14.Name = "AirConditionDem";
            treeNode14.Text = "查詢冷氣巡檢記錄";
            treeNode15.Name = "HydropowerDem";
            treeNode15.Text = "查詢水電巡檢記錄";
            treeNode16.Name = "Demand";
            treeNode16.Text = "查詢作業";
            treeNode17.Name = "TransportData";
            treeNode17.Text = "傳輸資料";
            treeNode18.Name = "Transport";
            treeNode18.Text = "傳輸作業";
            treeNode19.Name = "Setting";
            treeNode19.Text = "設定";
            treeNode20.Name = "Exit";
            treeNode20.Text = "離開";
            this.trvSelectFn.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode11,
            treeNode16,
            treeNode18,
            treeNode19,
            treeNode20});
            this.trvSelectFn.Size = new System.Drawing.Size(243, 633);
            this.trvSelectFn.TabIndex = 1;
            this.trvSelectFn.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvSelectFn_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 696);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView trvSelectFn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxLoginAccount;
        public System.Windows.Forms.TextBox tbxLoginRole;
        public System.Windows.Forms.SplitContainer splitContainer1;
    }
}

