namespace iwork
{
    partial class sales_other
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales_other));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn4 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn5 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn6 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn7 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn8 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn9 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn10 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn11 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn12 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订单日期 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.订单编号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.版本号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.商品型号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.商品名称 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.商品描述 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.签订单位 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.签订数量 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.销售单价 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.币别 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.销售金额 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.备注 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.核销 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.订单日期,
            this.订单编号,
            this.版本号,
            this.商品型号,
            this.商品名称,
            this.商品描述,
            this.签订单位,
            this.签订数量,
            this.销售单价,
            this.币别,
            this.销售金额,
            this.备注,
            this.核销,
            this.编号});
            this.dgv1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgv1.Location = new System.Drawing.Point(0, 32);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(844, 248);
            this.dgv1.TabIndex = 11;
            this.dgv1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv1_CellBeginEdit);
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellEndEdit);
            this.dgv1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv1_RowPrePaint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.添加ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 浏览ToolStripMenuItem
            // 
            this.浏览ToolStripMenuItem.Name = "浏览ToolStripMenuItem";
            this.浏览ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.浏览ToolStripMenuItem.Text = "刷新";
            this.浏览ToolStripMenuItem.Click += new System.EventHandler(this.浏览ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.DataPropertyName = "订单日期";
            this.dataGridViewAutoFilterTextBoxColumn1.HeaderText = "订单日期";
            this.dataGridViewAutoFilterTextBoxColumn1.Name = "dataGridViewAutoFilterTextBoxColumn1";
            this.dataGridViewAutoFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn2
            // 
            this.dataGridViewAutoFilterTextBoxColumn2.DataPropertyName = "订单编号";
            this.dataGridViewAutoFilterTextBoxColumn2.HeaderText = "订单编号";
            this.dataGridViewAutoFilterTextBoxColumn2.Name = "dataGridViewAutoFilterTextBoxColumn2";
            this.dataGridViewAutoFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn3
            // 
            this.dataGridViewAutoFilterTextBoxColumn3.DataPropertyName = "版本号";
            this.dataGridViewAutoFilterTextBoxColumn3.HeaderText = "版本号";
            this.dataGridViewAutoFilterTextBoxColumn3.Name = "dataGridViewAutoFilterTextBoxColumn3";
            this.dataGridViewAutoFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn4
            // 
            this.dataGridViewAutoFilterTextBoxColumn4.DataPropertyName = "商品代码";
            this.dataGridViewAutoFilterTextBoxColumn4.HeaderText = "商品代码";
            this.dataGridViewAutoFilterTextBoxColumn4.Name = "dataGridViewAutoFilterTextBoxColumn4";
            this.dataGridViewAutoFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn5
            // 
            this.dataGridViewAutoFilterTextBoxColumn5.DataPropertyName = "商品名称";
            this.dataGridViewAutoFilterTextBoxColumn5.HeaderText = "商品名称";
            this.dataGridViewAutoFilterTextBoxColumn5.Name = "dataGridViewAutoFilterTextBoxColumn5";
            this.dataGridViewAutoFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn6
            // 
            this.dataGridViewAutoFilterTextBoxColumn6.DataPropertyName = "签订单位";
            this.dataGridViewAutoFilterTextBoxColumn6.HeaderText = "签订单位";
            this.dataGridViewAutoFilterTextBoxColumn6.Name = "dataGridViewAutoFilterTextBoxColumn6";
            this.dataGridViewAutoFilterTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn7
            // 
            this.dataGridViewAutoFilterTextBoxColumn7.DataPropertyName = "签订数量";
            this.dataGridViewAutoFilterTextBoxColumn7.HeaderText = "签订数量";
            this.dataGridViewAutoFilterTextBoxColumn7.Name = "dataGridViewAutoFilterTextBoxColumn7";
            this.dataGridViewAutoFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn8
            // 
            this.dataGridViewAutoFilterTextBoxColumn8.DataPropertyName = "销售单价";
            this.dataGridViewAutoFilterTextBoxColumn8.HeaderText = "销售单价";
            this.dataGridViewAutoFilterTextBoxColumn8.Name = "dataGridViewAutoFilterTextBoxColumn8";
            this.dataGridViewAutoFilterTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn9
            // 
            this.dataGridViewAutoFilterTextBoxColumn9.DataPropertyName = "币别";
            this.dataGridViewAutoFilterTextBoxColumn9.HeaderText = "币别";
            this.dataGridViewAutoFilterTextBoxColumn9.Name = "dataGridViewAutoFilterTextBoxColumn9";
            this.dataGridViewAutoFilterTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn10
            // 
            this.dataGridViewAutoFilterTextBoxColumn10.DataPropertyName = "销售金额";
            this.dataGridViewAutoFilterTextBoxColumn10.HeaderText = "销售金额";
            this.dataGridViewAutoFilterTextBoxColumn10.Name = "dataGridViewAutoFilterTextBoxColumn10";
            this.dataGridViewAutoFilterTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn11
            // 
            this.dataGridViewAutoFilterTextBoxColumn11.DataPropertyName = "备注";
            this.dataGridViewAutoFilterTextBoxColumn11.HeaderText = "备注";
            this.dataGridViewAutoFilterTextBoxColumn11.Name = "dataGridViewAutoFilterTextBoxColumn11";
            this.dataGridViewAutoFilterTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn12
            // 
            this.dataGridViewAutoFilterTextBoxColumn12.DataPropertyName = "核销";
            this.dataGridViewAutoFilterTextBoxColumn12.HeaderText = "核销";
            this.dataGridViewAutoFilterTextBoxColumn12.Name = "dataGridViewAutoFilterTextBoxColumn12";
            this.dataGridViewAutoFilterTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "订单日期";
            this.dataGridViewTextBoxColumn1.HeaderText = "订单日期";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "订单编号";
            this.dataGridViewTextBoxColumn2.HeaderText = "订单编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "订单序列号";
            this.dataGridViewTextBoxColumn3.HeaderText = "订单序列号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "商品代码";
            this.dataGridViewTextBoxColumn4.HeaderText = "商品代码";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "商品名称";
            this.dataGridViewTextBoxColumn5.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "订单交期";
            this.dataGridViewTextBoxColumn6.HeaderText = "订单交期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "签订单位";
            this.dataGridViewTextBoxColumn7.HeaderText = "签订单位";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "签订数量";
            this.dataGridViewTextBoxColumn8.HeaderText = "签订数量";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "销售单价";
            this.dataGridViewTextBoxColumn9.HeaderText = "销售单价";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "币别";
            this.dataGridViewTextBoxColumn10.HeaderText = "币别";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "销售金额";
            this.dataGridViewTextBoxColumn11.HeaderText = "销售金额";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "备注";
            this.dataGridViewTextBoxColumn12.HeaderText = "备注";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // 订单日期
            // 
            this.订单日期.DataPropertyName = "订单日期";
            this.订单日期.HeaderText = "订单日期";
            this.订单日期.Name = "订单日期";
            this.订单日期.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 订单编号
            // 
            this.订单编号.DataPropertyName = "订单编号";
            this.订单编号.HeaderText = "订单编号";
            this.订单编号.Name = "订单编号";
            this.订单编号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 版本号
            // 
            this.版本号.DataPropertyName = "版本号";
            this.版本号.HeaderText = "版本号";
            this.版本号.Name = "版本号";
            this.版本号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 商品型号
            // 
            this.商品型号.DataPropertyName = "商品型号";
            this.商品型号.HeaderText = "商品型号";
            this.商品型号.Name = "商品型号";
            this.商品型号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 商品名称
            // 
            this.商品名称.DataPropertyName = "商品名称";
            this.商品名称.HeaderText = "商品名称";
            this.商品名称.Name = "商品名称";
            this.商品名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 商品描述
            // 
            this.商品描述.DataPropertyName = "商品描述";
            this.商品描述.HeaderText = "商品描述";
            this.商品描述.Name = "商品描述";
            this.商品描述.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 签订单位
            // 
            this.签订单位.DataPropertyName = "签订单位";
            this.签订单位.HeaderText = "签订单位";
            this.签订单位.Name = "签订单位";
            this.签订单位.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 签订数量
            // 
            this.签订数量.DataPropertyName = "签订数量";
            this.签订数量.HeaderText = "签订数量";
            this.签订数量.Name = "签订数量";
            this.签订数量.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 销售单价
            // 
            this.销售单价.DataPropertyName = "销售单价";
            this.销售单价.HeaderText = "销售单价";
            this.销售单价.Name = "销售单价";
            this.销售单价.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 币别
            // 
            this.币别.DataPropertyName = "币别";
            this.币别.HeaderText = "币别";
            this.币别.Name = "币别";
            this.币别.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 销售金额
            // 
            this.销售金额.DataPropertyName = "销售金额";
            this.销售金额.HeaderText = "销售金额";
            this.销售金额.Name = "销售金额";
            this.销售金额.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "备注";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 核销
            // 
            this.核销.DataPropertyName = "核销";
            this.核销.HeaderText = "核销";
            this.核销.Name = "核销";
            this.核销.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "编号";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.Visible = false;
            // 
            // sales_other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 280);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sales_other";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "其他零部件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sales_other_FormClosing);
            this.Load += new System.EventHandler(this.sales_other_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 订单日期;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 订单编号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 版本号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品型号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品名称;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 商品描述;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 签订单位;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 签订数量;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 销售单价;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 币别;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 销售金额;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 备注;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 核销;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn4;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn5;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn6;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn7;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn8;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn9;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn10;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn11;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn12;
    }
}