namespace SQLConnectionStringBuilder
{
    partial class MiniFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetSting = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pG4String = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // btnGetSting
            // 
            this.btnGetSting.Location = new System.Drawing.Point(632, 12);
            this.btnGetSting.Name = "btnGetSting";
            this.btnGetSting.Size = new System.Drawing.Size(975, 158);
            this.btnGetSting.TabIndex = 0;
            this.btnGetSting.Text = "Get String";
            this.btnGetSting.UseVisualStyleBackColor = true;
            this.btnGetSting.Click += new System.EventHandler(this.btnGetSting_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(577, 772);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pG4String
            // 
            this.pG4String.Location = new System.Drawing.Point(632, 176);
            this.pG4String.Name = "pG4String";
            this.pG4String.Size = new System.Drawing.Size(975, 596);
            this.pG4String.TabIndex = 2;
            // 
            // MiniFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 796);
            this.Controls.Add(this.pG4String);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGetSting);
            this.Name = "MiniFrm";
            this.Text = "StringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSting;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PropertyGrid pG4String;
    }
}

