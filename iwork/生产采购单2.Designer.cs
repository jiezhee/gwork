namespace iwork
{
    partial class 生产采购单2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(生产采购单2));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.NO = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.料号 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.品名 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.型号规格 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.单位 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.供应商 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.用量 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.使用位置 = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.料号,
            this.品名,
            this.型号规格,
            this.单位,
            this.供应商,
            this.用量,
            this.使用位置,
            this.备注});
            this.dgv1.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.dgv1.Location = new System.Drawing.Point(8, 8);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(704, 302);
            this.dgv1.TabIndex = 3;
            // 
            // NO
            // 
            this.NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NO.DataPropertyName = "NO";
            this.NO.Frozen = true;
            this.NO.HeaderText = "NO";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NO.Width = 50;
            // 
            // 料号
            // 
            this.料号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.料号.DataPropertyName = "料号";
            this.料号.HeaderText = "料号";
            this.料号.Name = "料号";
            this.料号.ReadOnly = true;
            this.料号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.料号.Width = 69;
            // 
            // 品名
            // 
            this.品名.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.品名.DataPropertyName = "品名";
            this.品名.HeaderText = "品名";
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            this.品名.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.品名.Width = 69;
            // 
            // 型号规格
            // 
            this.型号规格.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.型号规格.DataPropertyName = "型号规格";
            this.型号规格.HeaderText = "型号规格";
            this.型号规格.Name = "型号规格";
            this.型号规格.ReadOnly = true;
            this.型号规格.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.型号规格.Width = 93;
            // 
            // 单位
            // 
            this.单位.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.单位.DataPropertyName = "单位";
            this.单位.HeaderText = "单位";
            this.单位.Name = "单位";
            this.单位.ReadOnly = true;
            this.单位.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.单位.Width = 69;
            // 
            // 供应商
            // 
            this.供应商.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.供应商.DataPropertyName = "供应商";
            this.供应商.HeaderText = "供应商";
            this.供应商.Name = "供应商";
            this.供应商.ReadOnly = true;
            this.供应商.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.供应商.Width = 81;
            // 
            // 用量
            // 
            this.用量.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.用量.DataPropertyName = "用量";
            this.用量.HeaderText = "用量";
            this.用量.Name = "用量";
            this.用量.ReadOnly = true;
            this.用量.Width = 69;
            // 
            // 使用位置
            // 
            this.使用位置.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.使用位置.DataPropertyName = "使用位置";
            this.使用位置.HeaderText = "使用位置";
            this.使用位置.Name = "使用位置";
            this.使用位置.ReadOnly = true;
            this.使用位置.Width = 93;
            // 
            // 备注
            // 
            this.备注.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.备注.DataPropertyName = "BOM备注";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 54;
            // 
            // 生产采购单2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 460);
            this.Controls.Add(this.dgv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "生产采购单2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生产采购单";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn NO;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 料号;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 品名;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 型号规格;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 单位;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 供应商;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 用量;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn 使用位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}