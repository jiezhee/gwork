namespace iwork
{
    partial class 订单描述
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(订单描述));
            this.rt1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rt1
            // 
            this.rt1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rt1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rt1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rt1.Location = new System.Drawing.Point(0, 0);
            this.rt1.Name = "rt1";
            this.rt1.ReadOnly = true;
            this.rt1.Size = new System.Drawing.Size(538, 225);
            this.rt1.TabIndex = 0;
            this.rt1.Text = "";
            // 
            // 订单描述
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 225);
            this.Controls.Add(this.rt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "订单描述";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "订单描述";
            this.Load += new System.EventHandler(this.订单描述_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rt1;


    }
}