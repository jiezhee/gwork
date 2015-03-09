namespace iwork
{
    partial class 采购信息筛选
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(采购信息筛选));
            this.l1 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.l3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.确定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.l1.Location = new System.Drawing.Point(25, 56);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(68, 21);
            this.l1.TabIndex = 51;
            this.l1.Text = "物料NO";
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.Color.Khaki;
            this.t1.Location = new System.Drawing.Point(105, 56);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 21);
            this.t1.TabIndex = 50;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l2.Location = new System.Drawing.Point(25, 95);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(74, 21);
            this.l2.TabIndex = 40;
            this.l2.Text = "物料料号";
            // 
            // t2
            // 
            this.t2.BackColor = System.Drawing.Color.Khaki;
            this.t2.Location = new System.Drawing.Point(105, 95);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 21);
            this.t2.TabIndex = 36;
            // 
            // dtp1
            // 
            this.dtp1.CalendarMonthBackground = System.Drawing.Color.Violet;
            this.dtp1.CalendarTitleBackColor = System.Drawing.Color.YellowGreen;
            this.dtp1.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtp1.Location = new System.Drawing.Point(105, 136);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 21);
            this.dtp1.TabIndex = 54;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(105, 181);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 21);
            this.dtp2.TabIndex = 56;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.l3.Location = new System.Drawing.Point(25, 135);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(74, 21);
            this.l3.TabIndex = 57;
            this.l3.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(25, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "结束时间";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.确定ToolStripMenuItem,
            this.清空ToolStripMenuItem,
            this.取消ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 29);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 确定ToolStripMenuItem
            // 
            this.确定ToolStripMenuItem.Name = "确定ToolStripMenuItem";
            this.确定ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.确定ToolStripMenuItem.Text = "确定";
            this.确定ToolStripMenuItem.Click += new System.EventHandler(this.确定ToolStripMenuItem_Click);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // 取消ToolStripMenuItem
            // 
            this.取消ToolStripMenuItem.Name = "取消ToolStripMenuItem";
            this.取消ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.取消ToolStripMenuItem.Text = "取消";
            // 
            // 采购信息筛选
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(332, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "采购信息筛选";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "采购信息筛选";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        public System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label l2;
        public System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 确定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消ToolStripMenuItem;
    }
}