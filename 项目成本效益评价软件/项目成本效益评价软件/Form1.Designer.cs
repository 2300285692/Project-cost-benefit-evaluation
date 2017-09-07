namespace 项目成本效益评价软件
{
    partial class Form1
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
            this.sy = new System.Windows.Forms.DataGridView();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.njxz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ztz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jlr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nbhbl = new System.Windows.Forms.TextBox();
            this.tzhbl = new System.Windows.Forms.TextBox();
            this.jxz = new System.Windows.Forms.TextBox();
            this.hsq = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sy)).BeginInit();
            this.SuspendLayout();
            // 
            // sy
            // 
            this.sy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.lr,
            this.njxz});
            this.sy.Location = new System.Drawing.Point(380, 61);
            this.sy.Name = "sy";
            this.sy.RowTemplate.Height = 23;
            this.sy.Size = new System.Drawing.Size(343, 260);
            this.sy.TabIndex = 0;
            this.sy.CurrentCellDirtyStateChanged += new System.EventHandler(this.sy_CurrentCellDirtyStateChanged);
            // 
            // year
            // 
            this.year.HeaderText = "年";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // lr
            // 
            this.lr.HeaderText = "年利润";
            this.lr.Name = "lr";
            // 
            // njxz
            // 
            this.njxz.HeaderText = "年净现值";
            this.njxz.Name = "njxz";
            this.njxz.ReadOnly = true;
            // 
            // ztz
            // 
            this.ztz.Location = new System.Drawing.Point(124, 26);
            this.ztz.Name = "ztz";
            this.ztz.Size = new System.Drawing.Size(100, 21);
            this.ztz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "总投资";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "贴现率";
            // 
            // txl
            // 
            this.txl.Location = new System.Drawing.Point(124, 85);
            this.txl.Name = "txl";
            this.txl.Size = new System.Drawing.Size(100, 21);
            this.txl.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "净利润";
            // 
            // jlr
            // 
            this.jlr.Enabled = false;
            this.jlr.Location = new System.Drawing.Point(124, 160);
            this.jlr.Name = "jlr";
            this.jlr.Size = new System.Drawing.Size(100, 21);
            this.jlr.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "回收期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "投资回报率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "净现值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "内部回报率";
            // 
            // nbhbl
            // 
            this.nbhbl.Enabled = false;
            this.nbhbl.Location = new System.Drawing.Point(124, 406);
            this.nbhbl.Name = "nbhbl";
            this.nbhbl.Size = new System.Drawing.Size(100, 21);
            this.nbhbl.TabIndex = 12;
            // 
            // tzhbl
            // 
            this.tzhbl.Enabled = false;
            this.tzhbl.Location = new System.Drawing.Point(124, 283);
            this.tzhbl.Name = "tzhbl";
            this.tzhbl.Size = new System.Drawing.Size(100, 21);
            this.tzhbl.TabIndex = 13;
            // 
            // jxz
            // 
            this.jxz.Enabled = false;
            this.jxz.Location = new System.Drawing.Point(124, 346);
            this.jxz.Name = "jxz";
            this.jxz.Size = new System.Drawing.Size(100, 21);
            this.jxz.TabIndex = 14;
            // 
            // hsq
            // 
            this.hsq.Enabled = false;
            this.hsq.Location = new System.Drawing.Point(124, 218);
            this.hsq.Name = "hsq";
            this.hsq.Size = new System.Drawing.Size(100, 21);
            this.hsq.TabIndex = 15;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(380, 401);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 16;
            this.submit.Text = "确定";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(648, 401);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 17;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 486);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.hsq);
            this.Controls.Add(this.jxz);
            this.Controls.Add(this.tzhbl);
            this.Controls.Add(this.nbhbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jlr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ztz);
            this.Controls.Add(this.sy);
            this.Name = "Form1";
            this.Text = "项目成本效益评价软件";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sy;
        private System.Windows.Forms.TextBox ztz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jlr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nbhbl;
        private System.Windows.Forms.TextBox tzhbl;
        private System.Windows.Forms.TextBox jxz;
        private System.Windows.Forms.TextBox hsq;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn lr;
        private System.Windows.Forms.DataGridViewTextBoxColumn njxz;
    }
}

