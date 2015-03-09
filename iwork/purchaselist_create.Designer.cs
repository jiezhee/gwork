namespace iwork
{
    partial class purchaselist_create
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchaselist_create));
            this.浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn4 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单补料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单编号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.订单加入序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品型号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.商品名称 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.商品描述 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.生产状态 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.选择 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.成品num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // 浏览ToolStripMenuItem
            // 
            this.浏览ToolStripMenuItem.Name = "浏览ToolStripMenuItem";
            this.浏览ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.浏览ToolStripMenuItem.Text = "刷新";
            this.浏览ToolStripMenuItem.Click += new System.EventHandler(this.浏览ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览ToolStripMenuItem,
            this.订单补料ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.订单编号,
            this.订单加入序号,
            this.商品型号,
            this.商品名称,
            this.商品描述,
            this.生产状态,
            this.选择,
            this.成品num});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgv1.Location = new System.Drawing.Point(0, 29);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(644, 375);
            this.dgv1.TabIndex = 3;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.DataPropertyName = "订单编号";
            this.dataGridViewAutoFilterTextBoxColumn1.HeaderText = "订单编号";
            this.dataGridViewAutoFilterTextBoxColumn1.Name = "dataGridViewAutoFilterTextBoxColumn1";
            this.dataGridViewAutoFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn2
            // 
            this.dataGridViewAutoFilterTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn2.DataPropertyName = "商品型号";
            this.dataGridViewAutoFilterTextBoxColumn2.HeaderText = "商品型号";
            this.dataGridViewAutoFilterTextBoxColumn2.Name = "dataGridViewAutoFilterTextBoxColumn2";
            this.dataGridViewAutoFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn3
            // 
            this.dataGridViewAutoFilterTextBoxColumn3.DataPropertyName = "商品名称";
            this.dataGridViewAutoFilterTextBoxColumn3.HeaderText = "商品名称";
            this.dataGridViewAutoFilterTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewAutoFilterTextBoxColumn3.Name = "dataGridViewAutoFilterTextBoxColumn3";
            this.dataGridViewAutoFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn4
            // 
            this.dataGridViewAutoFilterTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewAutoFilterTextBoxColumn4.DataPropertyName = "商品描述";
            this.dataGridViewAutoFilterTextBoxColumn4.HeaderText = "商品描述";
            this.dataGridViewAutoFilterTextBoxColumn4.MinimumWidth = 140;
            this.dataGridViewAutoFilterTextBoxColumn4.Name = "dataGridViewAutoFilterTextBoxColumn4";
            this.dataGridViewAutoFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewButtonColumn1.HeaderText = "物料详细";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "点击";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn1.HeaderText = "代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn3.HeaderText = "编码";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn4.HeaderText = "编码";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn5.HeaderText = "编码";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // 订单补料ToolStripMenuItem
            // 
            this.订单补料ToolStripMenuItem.Name = "订单补料ToolStripMenuItem";
            this.订单补料ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.订单补料ToolStripMenuItem.Text = "订单补料";
            this.订单补料ToolStripMenuItem.Click += new System.EventHandler(this.订单补料ToolStripMenuItem_Click);
            // 
            // 订单编号
            // 
            this.订单编号.DataPropertyName = "订单编号";
            this.订单编号.HeaderText = "订单编号";
            this.订单编号.Name = "订单编号";
            this.订单编号.ReadOnly = true;
            this.订单编号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 订单加入序号
            // 
            this.订单加入序号.DataPropertyName = "加入序号";
            this.订单加入序号.HeaderText = "订单加入序号";
            this.订单加入序号.Name = "订单加入序号";
            this.订单加入序号.ReadOnly = true;
            this.订单加入序号.Visible = false;
            // 
            // 商品型号
            // 
            this.商品型号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.商品型号.DataPropertyName = "商品型号";
            this.商品型号.HeaderText = "商品型号";
            this.商品型号.Name = "商品型号";
            this.商品型号.ReadOnly = true;
            this.商品型号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 商品名称
            // 
            this.商品名称.DataPropertyName = "商品名称";
            this.商品名称.HeaderText = "商品名称";
            this.商品名称.MinimumWidth = 100;
            this.商品名称.Name = "商品名称";
            this.商品名称.ReadOnly = true;
            this.商品名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 商品描述
            // 
            this.商品描述.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.商品描述.DataPropertyName = "商品描述";
            this.商品描述.HeaderText = "商品描述";
            this.商品描述.MinimumWidth = 140;
            this.商品描述.Name = "商品描述";
            this.商品描述.ReadOnly = true;
            this.商品描述.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.商品描述.Width = 140;
            // 
            // 生产状态
            // 
            this.生产状态.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.生产状态.DataPropertyName = "生产状态";
            this.生产状态.HeaderText = "生产状态";
            this.生产状态.Name = "生产状态";
            this.生产状态.ReadOnly = true;
            // 
            // 选择
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.选择.DefaultCellStyle = dataGridViewCellStyle1;
            this.选择.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.ReadOnly = true;
            this.选择.Text = "选择";
            this.选择.UseColumnTextForButtonValue = true;
            this.选择.Width = 60;
            // 
            // 成品num
            // 
            this.成品num.DataPropertyName = "成品num";
            this.成品num.HeaderText = "成品num";
            this.成品num.Name = "成品num";
            this.成品num.ReadOnly = true;
            this.成品num.Visible = false;
            // 
            // purchaselist_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 404);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "purchaselist_create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生成采购单－当前等待采购的订单";
            this.Load += new System.EventHandler(this.purchaselist_create_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripMenuItem 浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem 订单补料ToolStripMenuItem;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 订单编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单加入序号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品型号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品名称;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品描述;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 生产状态;
        private System.Windows.Forms.DataGridViewButtonColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成品num;
    }
}