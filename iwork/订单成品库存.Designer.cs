namespace iwork
{
    partial class 订单成品库存
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(订单成品库存));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.订单加入序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成品num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单编号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.商品型号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.商品名称 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.商品描述 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本次库存变化 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出入库后总库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.出库 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn4 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("华文行楷", 15.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.撤销ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.订单加入序号,
            this.成品num,
            this.订单编号,
            this.商品型号,
            this.商品名称,
            this.商品描述,
            this.库存,
            this.本次库存变化,
            this.出入库后总库存,
            this.入库,
            this.出库});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgv1.Location = new System.Drawing.Point(0, 30);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(924, 308);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // 订单加入序号
            // 
            this.订单加入序号.DataPropertyName = "订单加入序号";
            this.订单加入序号.HeaderText = "订单加入序号";
            this.订单加入序号.Name = "订单加入序号";
            this.订单加入序号.ReadOnly = true;
            this.订单加入序号.Visible = false;
            // 
            // 成品num
            // 
            this.成品num.DataPropertyName = "成品num";
            this.成品num.HeaderText = "成品num";
            this.成品num.Name = "成品num";
            this.成品num.ReadOnly = true;
            this.成品num.Visible = false;
            // 
            // 订单编号
            // 
            this.订单编号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.订单编号.DataPropertyName = "订单编号";
            this.订单编号.HeaderText = "订单编号";
            this.订单编号.Name = "订单编号";
            this.订单编号.ReadOnly = true;
            this.订单编号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.商品名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // 库存
            // 
            this.库存.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.库存.DataPropertyName = "库存";
            this.库存.HeaderText = "库存";
            this.库存.Name = "库存";
            this.库存.ReadOnly = true;
            this.库存.Width = 80;
            // 
            // 本次库存变化
            // 
            this.本次库存变化.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.本次库存变化.HeaderText = "本次库存变化";
            this.本次库存变化.Name = "本次库存变化";
            this.本次库存变化.ReadOnly = true;
            // 
            // 出入库后总库存
            // 
            this.出入库后总库存.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.出入库后总库存.HeaderText = "出入库后总库存";
            this.出入库后总库存.Name = "出入库后总库存";
            this.出入库后总库存.ReadOnly = true;
            // 
            // 入库
            // 
            this.入库.HeaderText = "入库";
            this.入库.Name = "入库";
            this.入库.ReadOnly = true;
            this.入库.Text = "入库";
            this.入库.UseColumnTextForButtonValue = true;
            this.入库.Width = 80;
            // 
            // 出库
            // 
            this.出库.HeaderText = "出库";
            this.出库.Name = "出库";
            this.出库.ReadOnly = true;
            this.出库.Text = "出库";
            this.出库.UseColumnTextForButtonValue = true;
            this.出库.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "订单加入序号";
            this.dataGridViewTextBoxColumn1.HeaderText = "订单加入序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            this.dataGridViewAutoFilterTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "库存";
            this.dataGridViewTextBoxColumn2.HeaderText = "库存";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.HeaderText = "本次库存变化";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "出入库后总库存";
            this.dataGridViewTextBoxColumn4.HeaderText = "出入库后总库存";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "入库";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 80;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "出库";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Width = 80;
            // 
            // 订单成品库存
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 338);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "订单成品库存";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "订单成品库存";
            this.Load += new System.EventHandler(this.订单成品库存_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单加入序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成品num;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 订单编号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品型号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品名称;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品描述;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本次库存变化;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出入库后总库存;
        private System.Windows.Forms.DataGridViewButtonColumn 入库;
        private System.Windows.Forms.DataGridViewButtonColumn 出库;
    }
}