namespace iwork
{
    partial class pr_add2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pr_add2));
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.物料NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料料号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料型号规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物料供应商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.加入 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NO = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.料号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.品名 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.型号规格 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.单位 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.供应商 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.类别 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewAutoFilterTextBoxColumn1 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn2 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn3 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn4 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn5 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewAutoFilterTextBoxColumn6 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv2.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物料NO,
            this.物料料号,
            this.物料品名,
            this.物料型号规格,
            this.物料单位,
            this.物料供应商});
            this.dgv2.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgv2.Location = new System.Drawing.Point(5, 32);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowTemplate.Height = 23;
            this.dgv2.Size = new System.Drawing.Size(325, 359);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellClick);
            // 
            // 物料NO
            // 
            this.物料NO.HeaderText = "物料NO";
            this.物料NO.Name = "物料NO";
            this.物料NO.ReadOnly = true;
            this.物料NO.Width = 80;
            // 
            // 物料料号
            // 
            this.物料料号.HeaderText = "物料料号";
            this.物料料号.Name = "物料料号";
            this.物料料号.ReadOnly = true;
            // 
            // 物料品名
            // 
            this.物料品名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.物料品名.HeaderText = "物料品名";
            this.物料品名.Name = "物料品名";
            this.物料品名.ReadOnly = true;
            // 
            // 物料型号规格
            // 
            this.物料型号规格.HeaderText = "物料型号规格";
            this.物料型号规格.Name = "物料型号规格";
            this.物料型号规格.ReadOnly = true;
            this.物料型号规格.Visible = false;
            // 
            // 物料单位
            // 
            this.物料单位.HeaderText = "物料单位";
            this.物料单位.Name = "物料单位";
            this.物料单位.ReadOnly = true;
            this.物料单位.Visible = false;
            // 
            // 物料供应商
            // 
            this.物料供应商.HeaderText = "物料供应商";
            this.物料供应商.Name = "物料供应商";
            this.物料供应商.ReadOnly = true;
            this.物料供应商.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgv1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.加入,
            this.NO,
            this.料号,
            this.品名,
            this.型号规格,
            this.单位,
            this.供应商,
            this.类别,
            this.flag});
            this.dgv1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgv1.Location = new System.Drawing.Point(336, 32);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(638, 359);
            this.dgv1.TabIndex = 2;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv1_RowPrePaint);
            // 
            // 加入
            // 
            this.加入.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            this.加入.DefaultCellStyle = dataGridViewCellStyle1;
            this.加入.HeaderText = "加入";
            this.加入.MinimumWidth = 10;
            this.加入.Name = "加入";
            this.加入.ReadOnly = true;
            this.加入.Text = "加入";
            this.加入.UseColumnTextForButtonValue = true;
            this.加入.Width = 40;
            // 
            // NO
            // 
            this.NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NO.DataPropertyName = "NO";
            this.NO.HeaderText = "NO";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NO.Width = 60;
            // 
            // 料号
            // 
            this.料号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.料号.DataPropertyName = "料号";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.料号.DefaultCellStyle = dataGridViewCellStyle2;
            this.料号.HeaderText = "料号";
            this.料号.MinimumWidth = 60;
            this.料号.Name = "料号";
            this.料号.ReadOnly = true;
            this.料号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.料号.Width = 80;
            // 
            // 品名
            // 
            this.品名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.品名.DataPropertyName = "品名";
            this.品名.HeaderText = "品名";
            this.品名.MinimumWidth = 60;
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            this.品名.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.品名.Width = 72;
            // 
            // 型号规格
            // 
            this.型号规格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.型号规格.DataPropertyName = "型号规格";
            this.型号规格.HeaderText = "型号规格";
            this.型号规格.Name = "型号规格";
            this.型号规格.ReadOnly = true;
            this.型号规格.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.型号规格.Width = 96;
            // 
            // 单位
            // 
            this.单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.单位.DataPropertyName = "单位";
            this.单位.HeaderText = "单位";
            this.单位.Name = "单位";
            this.单位.ReadOnly = true;
            this.单位.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.单位.Width = 60;
            // 
            // 供应商
            // 
            this.供应商.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.供应商.DataPropertyName = "供应商";
            this.供应商.HeaderText = "供应商";
            this.供应商.Name = "供应商";
            this.供应商.ReadOnly = true;
            this.供应商.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.供应商.Width = 84;
            // 
            // 类别
            // 
            this.类别.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.类别.DataPropertyName = "类别";
            this.类别.HeaderText = "类别";
            this.类别.Name = "类别";
            this.类别.ReadOnly = true;
            // 
            // flag
            // 
            this.flag.DataPropertyName = "flag";
            this.flag.HeaderText = "flag";
            this.flag.Name = "flag";
            this.flag.ReadOnly = true;
            this.flag.Visible = false;
            this.flag.Width = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加完成ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加完成ToolStripMenuItem
            // 
            this.添加完成ToolStripMenuItem.Name = "添加完成ToolStripMenuItem";
            this.添加完成ToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.添加完成ToolStripMenuItem.Text = "确认添加";
            this.添加完成ToolStripMenuItem.Click += new System.EventHandler(this.确认添加ToolStripMenuItem_Click);
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
            this.退出ToolStripMenuItem.Text = "取消";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "物料代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "物料名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn1.HeaderText = "加入";
            this.dataGridViewButtonColumn1.MinimumWidth = 10;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "加入";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 22;
            // 
            // dataGridViewAutoFilterTextBoxColumn1
            // 
            this.dataGridViewAutoFilterTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn1.DataPropertyName = "NO";
            this.dataGridViewAutoFilterTextBoxColumn1.HeaderText = "NO";
            this.dataGridViewAutoFilterTextBoxColumn1.Name = "dataGridViewAutoFilterTextBoxColumn1";
            this.dataGridViewAutoFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn1.Width = 50;
            // 
            // dataGridViewAutoFilterTextBoxColumn2
            // 
            this.dataGridViewAutoFilterTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn2.DataPropertyName = "料号";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewAutoFilterTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAutoFilterTextBoxColumn2.HeaderText = "料号";
            this.dataGridViewAutoFilterTextBoxColumn2.MinimumWidth = 60;
            this.dataGridViewAutoFilterTextBoxColumn2.Name = "dataGridViewAutoFilterTextBoxColumn2";
            this.dataGridViewAutoFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn2.Width = 80;
            // 
            // dataGridViewAutoFilterTextBoxColumn3
            // 
            this.dataGridViewAutoFilterTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewAutoFilterTextBoxColumn3.DataPropertyName = "品名";
            this.dataGridViewAutoFilterTextBoxColumn3.HeaderText = "品名";
            this.dataGridViewAutoFilterTextBoxColumn3.MinimumWidth = 60;
            this.dataGridViewAutoFilterTextBoxColumn3.Name = "dataGridViewAutoFilterTextBoxColumn3";
            this.dataGridViewAutoFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn4
            // 
            this.dataGridViewAutoFilterTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewAutoFilterTextBoxColumn4.DataPropertyName = "型号规格";
            this.dataGridViewAutoFilterTextBoxColumn4.HeaderText = "型号规格";
            this.dataGridViewAutoFilterTextBoxColumn4.Name = "dataGridViewAutoFilterTextBoxColumn4";
            this.dataGridViewAutoFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewAutoFilterTextBoxColumn5
            // 
            this.dataGridViewAutoFilterTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewAutoFilterTextBoxColumn5.DataPropertyName = "单位";
            this.dataGridViewAutoFilterTextBoxColumn5.HeaderText = "单位";
            this.dataGridViewAutoFilterTextBoxColumn5.Name = "dataGridViewAutoFilterTextBoxColumn5";
            this.dataGridViewAutoFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoFilterTextBoxColumn5.Width = 60;
            // 
            // dataGridViewAutoFilterTextBoxColumn6
            // 
            this.dataGridViewAutoFilterTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewAutoFilterTextBoxColumn6.DataPropertyName = "供应商";
            this.dataGridViewAutoFilterTextBoxColumn6.HeaderText = "供应商";
            this.dataGridViewAutoFilterTextBoxColumn6.Name = "dataGridViewAutoFilterTextBoxColumn6";
            this.dataGridViewAutoFilterTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "代码";
            this.dataGridViewTextBoxColumn3.HeaderText = "代码";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "名称";
            this.dataGridViewTextBoxColumn4.HeaderText = "名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "商品类型";
            this.dataGridViewTextBoxColumn5.HeaderText = "商品类型";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "规格型号";
            this.dataGridViewTextBoxColumn6.HeaderText = "规格型号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "基本单位";
            this.dataGridViewTextBoxColumn7.HeaderText = "基本单位";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "计价方法";
            this.dataGridViewTextBoxColumn8.HeaderText = "计价方法";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "flag";
            this.dataGridViewTextBoxColumn9.HeaderText = "flag";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 5;
            // 
            // pr_add2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 394);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pr_add2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "物料添加";
            this.Load += new System.EventHandler(this.pr_add2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        public System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加完成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn2;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn3;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn4;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn5;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn dataGridViewAutoFilterTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn 加入;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn NO;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 料号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 品名;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 型号规格;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 单位;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 供应商;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料料号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料型号规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料供应商;
    }
}