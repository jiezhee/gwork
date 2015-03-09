namespace iwork
{
    partial class 用户管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(用户管理));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增添用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基础物料 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.成品 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.销售管理＿所有权限 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.销售管理＿部分权限 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.采购管理 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.仓库管理_物料 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.仓库管理_成品 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.生产管理 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.用户管理权限 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.用户名,
            this.密码,
            this.基础物料,
            this.成品,
            this.销售管理＿所有权限,
            this.销售管理＿部分权限,
            this.采购管理,
            this.仓库管理_物料,
            this.仓库管理_成品,
            this.生产管理,
            this.用户管理权限});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgv1.Location = new System.Drawing.Point(0, 29);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(1059, 260);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv1_CellBeginEdit);
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellEndEdit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.保存修改ToolStripMenuItem,
            this.增添用户ToolStripMenuItem,
            this.删除用户ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 保存修改ToolStripMenuItem
            // 
            this.保存修改ToolStripMenuItem.Name = "保存修改ToolStripMenuItem";
            this.保存修改ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.保存修改ToolStripMenuItem.Text = "保存修改";
            this.保存修改ToolStripMenuItem.Click += new System.EventHandler(this.保存修改ToolStripMenuItem_Click);
            // 
            // 增添用户ToolStripMenuItem
            // 
            this.增添用户ToolStripMenuItem.Name = "增添用户ToolStripMenuItem";
            this.增添用户ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.增添用户ToolStripMenuItem.Text = "增添用户";
            this.增添用户ToolStripMenuItem.Click += new System.EventHandler(this.增添用户ToolStripMenuItem_Click);
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            this.删除用户ToolStripMenuItem.Click += new System.EventHandler(this.删除用户ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "编号";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "用户名";
            this.dataGridViewTextBoxColumn2.HeaderText = "用户名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "密码";
            this.dataGridViewTextBoxColumn3.HeaderText = "密码";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "基础物料";
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.HeaderText = "基础物料";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "成品";
            this.dataGridViewCheckBoxColumn2.FalseValue = "0";
            this.dataGridViewCheckBoxColumn2.HeaderText = "成品";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.TrueValue = "1";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "销售管理";
            this.dataGridViewCheckBoxColumn3.FalseValue = "0";
            this.dataGridViewCheckBoxColumn3.HeaderText = "销售管理";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.TrueValue = "1";
            this.dataGridViewCheckBoxColumn3.Width = 150;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "采购管理";
            this.dataGridViewCheckBoxColumn4.FalseValue = "0";
            this.dataGridViewCheckBoxColumn4.HeaderText = "采购管理";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn4.TrueValue = "1";
            this.dataGridViewCheckBoxColumn4.Width = 150;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "仓库管理_物料";
            this.dataGridViewCheckBoxColumn5.FalseValue = "0";
            this.dataGridViewCheckBoxColumn5.HeaderText = "仓库管理_物料";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.TrueValue = "1";
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "仓库管理_成品";
            this.dataGridViewCheckBoxColumn6.FalseValue = "0";
            this.dataGridViewCheckBoxColumn6.HeaderText = "仓库管理_成品";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.TrueValue = "1";
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.DataPropertyName = "生产管理";
            this.dataGridViewCheckBoxColumn7.FalseValue = "0";
            this.dataGridViewCheckBoxColumn7.HeaderText = "生产管理";
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            this.dataGridViewCheckBoxColumn7.TrueValue = "1";
            // 
            // dataGridViewCheckBoxColumn8
            // 
            this.dataGridViewCheckBoxColumn8.DataPropertyName = "设置";
            this.dataGridViewCheckBoxColumn8.FalseValue = "0";
            this.dataGridViewCheckBoxColumn8.HeaderText = "设置";
            this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
            this.dataGridViewCheckBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn8.TrueValue = "1";
            // 
            // dataGridViewCheckBoxColumn9
            // 
            this.dataGridViewCheckBoxColumn9.DataPropertyName = "设置";
            this.dataGridViewCheckBoxColumn9.FalseValue = "0";
            this.dataGridViewCheckBoxColumn9.HeaderText = "设置";
            this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
            this.dataGridViewCheckBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn9.TrueValue = "1";
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "编号";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.Visible = false;
            // 
            // 用户名
            // 
            this.用户名.DataPropertyName = "用户名";
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            // 
            // 密码
            // 
            this.密码.DataPropertyName = "密码";
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            // 
            // 基础物料
            // 
            this.基础物料.DataPropertyName = "基础物料";
            this.基础物料.FalseValue = "0";
            this.基础物料.HeaderText = "基础物料";
            this.基础物料.Name = "基础物料";
            this.基础物料.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.基础物料.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.基础物料.TrueValue = "1";
            // 
            // 成品
            // 
            this.成品.DataPropertyName = "成品";
            this.成品.FalseValue = "0";
            this.成品.HeaderText = "成品管理";
            this.成品.Name = "成品";
            this.成品.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.成品.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.成品.TrueValue = "1";
            // 
            // 销售管理＿所有权限
            // 
            this.销售管理＿所有权限.DataPropertyName = "销售管理＿所有权限";
            this.销售管理＿所有权限.FalseValue = "0";
            this.销售管理＿所有权限.HeaderText = "销售管理＿所有权限";
            this.销售管理＿所有权限.Name = "销售管理＿所有权限";
            this.销售管理＿所有权限.TrueValue = "1";
            this.销售管理＿所有权限.Width = 150;
            // 
            // 销售管理＿部分权限
            // 
            this.销售管理＿部分权限.DataPropertyName = "销售管理＿部分权限";
            this.销售管理＿部分权限.FalseValue = "0";
            this.销售管理＿部分权限.HeaderText = "销售管理＿部分权限";
            this.销售管理＿部分权限.Name = "销售管理＿部分权限";
            this.销售管理＿部分权限.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.销售管理＿部分权限.TrueValue = "1";
            this.销售管理＿部分权限.Width = 150;
            // 
            // 采购管理
            // 
            this.采购管理.DataPropertyName = "采购管理";
            this.采购管理.FalseValue = "0";
            this.采购管理.HeaderText = "采购管理";
            this.采购管理.Name = "采购管理";
            this.采购管理.TrueValue = "1";
            // 
            // 仓库管理_物料
            // 
            this.仓库管理_物料.DataPropertyName = "仓库管理_物料";
            this.仓库管理_物料.FalseValue = "0";
            this.仓库管理_物料.HeaderText = "仓库管理_物料";
            this.仓库管理_物料.Name = "仓库管理_物料";
            this.仓库管理_物料.TrueValue = "1";
            // 
            // 仓库管理_成品
            // 
            this.仓库管理_成品.DataPropertyName = "仓库管理_成品";
            this.仓库管理_成品.FalseValue = "0";
            this.仓库管理_成品.HeaderText = "仓库管理_成品";
            this.仓库管理_成品.Name = "仓库管理_成品";
            this.仓库管理_成品.TrueValue = "1";
            // 
            // 生产管理
            // 
            this.生产管理.DataPropertyName = "生产管理";
            this.生产管理.FalseValue = "0";
            this.生产管理.HeaderText = "生产管理";
            this.生产管理.Name = "生产管理";
            this.生产管理.TrueValue = "1";
            // 
            // 用户管理权限
            // 
            this.用户管理权限.DataPropertyName = "用户管理权限";
            this.用户管理权限.FalseValue = "0";
            this.用户管理权限.HeaderText = "用户管理权限";
            this.用户管理权限.Name = "用户管理权限";
            this.用户管理权限.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.用户管理权限.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.用户管理权限.TrueValue = "1";
            // 
            // 用户管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 289);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "用户管理";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.用户管理_FormClosing);
            this.Load += new System.EventHandler(this.用户管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 保存修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增添用户ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 基础物料;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 成品;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 销售管理＿所有权限;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 销售管理＿部分权限;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 采购管理;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 仓库管理_物料;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 仓库管理_成品;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 生产管理;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 用户管理权限;
    }
}