namespace iwork
{
    partial class 仓库管理_物料
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(仓库管理_物料));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.物料NO = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.料号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.品名 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.单独库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单内库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本次库存变化 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出入库后总库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.出库 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("华文行楷", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础录入ToolStripMenuItem,
            this.撤销ToolStripMenuItem,
            this.搜索ToolStripMenuItem,
            this.新增ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础录入ToolStripMenuItem
            // 
            this.基础录入ToolStripMenuItem.Font = new System.Drawing.Font("华文行楷", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.基础录入ToolStripMenuItem.Name = "基础录入ToolStripMenuItem";
            this.基础录入ToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.基础录入ToolStripMenuItem.Text = "刷新";
            this.基础录入ToolStripMenuItem.Click += new System.EventHandler(this.基础录入ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.搜索ToolStripMenuItem.Text = "搜索";
            this.搜索ToolStripMenuItem.Click += new System.EventHandler(this.搜索ToolStripMenuItem_Click);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.新增ToolStripMenuItem.Text = "新增物料";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
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
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物料NO,
            this.料号,
            this.品名,
            this.单独库存,
            this.订单内库存,
            this.总库存,
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
            this.dgv1.Size = new System.Drawing.Size(1063, 351);
            this.dgv1.TabIndex = 2;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "物料代码";
            this.dataGridViewTextBoxColumn1.HeaderText = "物料代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "名称";
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "全名";
            this.dataGridViewTextBoxColumn3.HeaderText = "全名";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "库存";
            this.dataGridViewTextBoxColumn4.HeaderText = "库存";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "本次库存变化";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "总库存";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn1.HeaderText = "入库";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn2.HeaderText = "出库";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            // 
            // 物料NO
            // 
            this.物料NO.DataPropertyName = "物料NO";
            this.物料NO.HeaderText = "物料NO";
            this.物料NO.Name = "物料NO";
            this.物料NO.ReadOnly = true;
            this.物料NO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 料号
            // 
            this.料号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.料号.DataPropertyName = "料号";
            this.料号.HeaderText = "料号";
            this.料号.Name = "料号";
            this.料号.ReadOnly = true;
            this.料号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 品名
            // 
            this.品名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.品名.DataPropertyName = "品名";
            this.品名.HeaderText = "品名";
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            this.品名.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 单独库存
            // 
            this.单独库存.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.单独库存.DataPropertyName = "单独库存";
            this.单独库存.HeaderText = "单独库存";
            this.单独库存.Name = "单独库存";
            this.单独库存.ReadOnly = true;
            // 
            // 订单内库存
            // 
            this.订单内库存.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.订单内库存.DataPropertyName = "库存";
            this.订单内库存.HeaderText = "订单内库存";
            this.订单内库存.Name = "订单内库存";
            this.订单内库存.ReadOnly = true;
            // 
            // 总库存
            // 
            this.总库存.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.总库存.DataPropertyName = "总库存";
            this.总库存.HeaderText = "总库存";
            this.总库存.Name = "总库存";
            this.总库存.ReadOnly = true;
            // 
            // 本次库存变化
            // 
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
            this.出入库后总库存.Width = 120;
            // 
            // 入库
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            this.入库.DefaultCellStyle = dataGridViewCellStyle1;
            this.入库.HeaderText = "入库";
            this.入库.Name = "入库";
            this.入库.ReadOnly = true;
            this.入库.Text = "入库";
            this.入库.UseColumnTextForButtonValue = true;
            // 
            // 出库
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.出库.DefaultCellStyle = dataGridViewCellStyle2;
            this.出库.HeaderText = "出库";
            this.出库.Name = "出库";
            this.出库.ReadOnly = true;
            this.出库.Text = "出库";
            this.出库.UseColumnTextForButtonValue = true;
            // 
            // 仓库管理_物料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 381);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "仓库管理_物料";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "仓库管理_物料";
            this.Load += new System.EventHandler(this.仓库管理_物料_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 物料NO;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 料号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单独库存;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单内库存;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总库存;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本次库存变化;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出入库后总库存;
        private System.Windows.Forms.DataGridViewButtonColumn 入库;
        private System.Windows.Forms.DataGridViewButtonColumn 出库;
    }
}