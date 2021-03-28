
namespace P_4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtNumerator1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDenominator1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumerator2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDenominator2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumerator3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDenominator3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(25, 127);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "=";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 26);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 12);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "분수1";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumerator1
            // 
            this.txtNumerator1.Location = new System.Drawing.Point(135, 23);
            this.txtNumerator1.Name = "txtNumerator1";
            this.txtNumerator1.Size = new System.Drawing.Size(100, 21);
            this.txtNumerator1.TabIndex = 2;
            this.txtNumerator1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "분자";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "분모";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDenominator1
            // 
            this.txtDenominator1.Location = new System.Drawing.Point(135, 50);
            this.txtDenominator1.Name = "txtDenominator1";
            this.txtDenominator1.Size = new System.Drawing.Size(100, 21);
            this.txtDenominator1.TabIndex = 2;
            this.txtDenominator1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "분수2";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "분자";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumerator2
            // 
            this.txtNumerator2.Location = new System.Drawing.Point(475, 26);
            this.txtNumerator2.Name = "txtNumerator2";
            this.txtNumerator2.Size = new System.Drawing.Size(100, 21);
            this.txtNumerator2.TabIndex = 2;
            this.txtNumerator2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "분모";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDenominator2
            // 
            this.txtDenominator2.Location = new System.Drawing.Point(475, 53);
            this.txtDenominator2.Name = "txtDenominator2";
            this.txtDenominator2.Size = new System.Drawing.Size(100, 21);
            this.txtDenominator2.TabIndex = 2;
            this.txtDenominator2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "+";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "결과";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "분자";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumerator3
            // 
            this.txtNumerator3.Location = new System.Drawing.Point(256, 129);
            this.txtNumerator3.Name = "txtNumerator3";
            this.txtNumerator3.Size = new System.Drawing.Size(100, 21);
            this.txtNumerator3.TabIndex = 2;
            this.txtNumerator3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "분모";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDenominator3
            // 
            this.txtDenominator3.Location = new System.Drawing.Point(256, 156);
            this.txtDenominator3.Name = "txtDenominator3";
            this.txtDenominator3.Size = new System.Drawing.Size(100, 21);
            this.txtDenominator3.TabIndex = 2;
            this.txtDenominator3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 236);
            this.Controls.Add(this.txtDenominator2);
            this.Controls.Add(this.txtDenominator3);
            this.Controls.Add(this.txtDenominator1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumerator2);
            this.Controls.Add(this.txtNumerator3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumerator1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "분수 계산";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtNumerator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDenominator1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumerator2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDenominator2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumerator3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDenominator3;
    }
}

