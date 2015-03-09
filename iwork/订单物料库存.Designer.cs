namespace iwork
{
    partial class 订单物料库存
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(订单物料库存));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.订单加入序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料NO = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.料号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.品名 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.型号规格 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.单位 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.使用位置 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.供应商 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.采购数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本次库存变化 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出入库后总库存 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.出库 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.到齐 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.准许生产ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn4 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn5 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn6 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn7 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.订单加入序号,
            this.物料NO,
            this.料号,
            this.品名,
            this.型号规格,
            this.单位,
            this.使用位置,
            this.供应商,
            this.采购数量,
            this.库存,
            this.本次库存变化,
            this.出入库后总库存,
            this.入库,
            this.出库,
            this.到齐});
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgv1.Location = new System.Drawing.Point(0, 29);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(1315, 440);
            this.dgv1.TabIndex = 4;
            this.dgv1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv1_CellBeginEdit);
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellEndEdit);
            // 
            // 订单加入序号
            // 
            this.订单加入序号.DataPropertyName = "订单加入序号";
            this.订单加入序号.HeaderText = "订单加入序号";
            this.订单加入序号.Name = "订单加入序号";
            this.订单加入序号.Visible = false;
            this.订单加入序号.Width = 5;
            // 
            // 物料NO
            // 
            this.物料NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // 型号规格
            // 
            this.型号规格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.型号规格.DataPropertyName = "型号规格";
            this.型号规格.HeaderText = "型号规格";
            this.型号规格.MinimumWidth = 100;
            this.型号规格.Name = "型号规格";
            this.型号规格.ReadOnly = true;
            this.型号规格.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 单位
            // 
            this.单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.单位.DataPropertyName = "单位";
            this.单位.HeaderText = "单位";
            this.单位.Name = "单位";
            this.单位.ReadOnly = true;
            this.单位.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 使用位置
            // 
            this.使用位置.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.使用位置.DataPropertyName = "使用位置";
            this.使用位置.HeaderText = "使用位置";
            this.使用位置.Name = "使用位置";
            this.使用位置.ReadOnly = true;
            this.使用位置.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 供应商
            // 
            this.供应商.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.供应商.DataPropertyName = "供应商";
            this.供应商.HeaderText = "供应商";
            this.供应商.MinimumWidth = 100;
            this.供应商.Name = "供应商";
            this.供应商.ReadOnly = true;
            this.供应商.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 采购数量
            // 
            this.采购数量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.采购数量.DataPropertyName = "采购数量";
            this.采购数量.HeaderText = "采购数量";
            this.采购数量.Name = "采购数量";
            this.采购数量.ReadOnly = true;
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
            this.本次库存变化.MinimumWidth = 100;
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
            this.入库.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.入库.HeaderText = "入库";
            this.入库.MinimumWidth = 50;
            this.入库.Name = "入库";
            this.入库.Text = "入库";
            this.入库.UseColumnTextForButtonValue = true;
            this.入库.Width = 50;
            // 
            // 出库
            // 
            this.出库.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.出库.HeaderText = "出库";
            this.出库.MinimumWidth = 50;
            this.出库.Name = "出库";
            this.出库.Text = "出库";
            this.出库.UseColumnTextForButtonValue = true;
            this.出库.Width = 50;
            // 
            // 到齐
            // 
            this.到齐.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.到齐.DataPropertyName = "到齐";
            this.到齐.FalseValue = "0";
            this.到齐.HeaderText = "到齐";
            this.到齐.MinimumWidth = 70;
            this.到齐.Name = "到齐";
            this.到齐.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.到齐.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.到齐.TrueValue = "1";
            this.到齐.Width = 70;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("华文行楷", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.撤销ToolStripMenuItem,
            this.准许生产ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1315, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 准许生产ToolStripMenuItem
            // 
            this.准许生产ToolStripMenuItem.Name = "准许生产ToolStripMenuItem";
            this.准许生产ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.准许生产ToolStripMenuItem.Text = "准许生产";
            this.准许生产ToolStripMenuItem.Click += new System.EventHandler(this.准许生产ToolStripMenuItem_Click);
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "序号";
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn1.DataPropertyName = "物料NO";
            this.dataGridViewAutoFilterTextBoxColumn1.HeaderText = "物料NO";
            this.dataGridViewAutoFilterTextBoxColumn1.Name = "dataGridViewAutoFilterTextBoxColumn1";
            this.dataGridViewAutoFilterTextBoxColumn1.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn2
            // 
            this.dataGridViewAutoFilterTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn2.DataPropertyName = "料号";
            this.dataGridViewAutoFilterTextBoxColumn2.HeaderText = "料号";
            this.dataGridViewAutoFilterTextBoxColumn2.Name = "dataGridViewAutoFilterTextBoxColumn2";
            this.dataGridViewAutoFilterTextBoxColumn2.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn3
            // 
            this.dataGridViewAutoFilterTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn3.DataPropertyName = "品名";
            this.dataGridViewAutoFilterTextBoxColumn3.HeaderText = "品名";
            this.dataGridViewAutoFilterTextBoxColumn3.Name = "dataGridViewAutoFilterTextBoxColumn3";
            this.dataGridViewAutoFilterTextBoxColumn3.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn4
            // 
            this.dataGridViewAutoFilterTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn4.DataPropertyName = "型号规格";
            this.dataGridViewAutoFilterTextBoxColumn4.HeaderText = "型号规格";
            this.dataGridViewAutoFilterTextBoxColumn4.MinimumWidth = 100;
            this.dataGridViewAutoFilterTextBoxColumn4.Name = "dataGridViewAutoFilterTextBoxColumn4";
            this.dataGridViewAutoFilterTextBoxColumn4.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn5
            // 
            this.dataGridViewAutoFilterTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn5.DataPropertyName = "单位";
            this.dataGridViewAutoFilterTextBoxColumn5.HeaderText = "单位";
            this.dataGridViewAutoFilterTextBoxColumn5.Name = "dataGridViewAutoFilterTextBoxColumn5";
            this.dataGridViewAutoFilterTextBoxColumn5.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn6
            // 
            this.dataGridViewAutoFilterTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn6.DataPropertyName = "使用位置";
            this.dataGridViewAutoFilterTextBoxColumn6.HeaderText = "使用位置";
            this.dataGridViewAutoFilterTextBoxColumn6.Name = "dataGridViewAutoFilterTextBoxColumn6";
            this.dataGridViewAutoFilterTextBoxColumn6.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn7
            // 
            this.dataGridViewAutoFilterTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn7.DataPropertyName = "供应商";
            this.dataGridViewAutoFilterTextBoxColumn7.HeaderText = "供应商";
            this.dataGridViewAutoFilterTextBoxColumn7.MinimumWidth = 100;
            this.dataGridViewAutoFilterTextBoxColumn7.Name = "dataGridViewAutoFilterTextBoxColumn7";
            this.dataGridViewAutoFilterTextBoxColumn7.ReadOnly = true;
            this.dataGridViewAutoFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NO";
            this.dataGridViewTextBoxColumn2.HeaderText = "物料NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "料号";
            this.dataGridViewTextBoxColumn3.HeaderText = "料号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "品名";
            this.dataGridViewTextBoxColumn4.HeaderText = "品名";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "到料审核";
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.HeaderText = "到料审核";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 100;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "型号规格";
            this.dataGridViewTextBoxColumn5.HeaderText = "型号规格";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "单位";
            this.dataGridViewTextBoxColumn6.HeaderText = "单位";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "使用位置";
            this.dataGridViewTextBoxColumn7.HeaderText = "使用位置";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "供应商";
            this.dataGridViewTextBoxColumn8.HeaderText = "供应商";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.HeaderText = "库存";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "采购数量";
            this.dataGridViewTextBoxColumn10.HeaderText = "采购数量";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.HeaderText = "物料审核";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // 订单物料库存
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 469);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "订单物料库存";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "订单物料库存";
            this.Load += new System.EventHandler(this.采购状态_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn4;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn5;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn6;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn7;
        public System.Windows.Forms.ToolStripMenuItem 准许生产ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单加入序号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 物料NO;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 料号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 品名;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 型号规格;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 单位;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 使用位置;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 供应商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 采购数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本次库存变化;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出入库后总库存;
        private System.Windows.Forms.DataGridViewButtonColumn 入库;
        private System.Windows.Forms.DataGridViewButtonColumn 出库;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 到齐;
    }
}