
namespace problem_4
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
            this.txtDan = new System.Windows.Forms.TextBox();
            this.lblDan = new System.Windows.Forms.Label();
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.lblCalc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(124, 123);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Excute";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtDan
            // 
            this.txtDan.Location = new System.Drawing.Point(124, 56);
            this.txtDan.Name = "txtDan";
            this.txtDan.Size = new System.Drawing.Size(69, 21);
            this.txtDan.TabIndex = 1;
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Location = new System.Drawing.Point(41, 59);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(17, 12);
            this.lblDan.TabIndex = 2;
            this.lblDan.Text = "단";
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(124, 186);
            this.txtCalc.Multiline = true;
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.Size = new System.Drawing.Size(169, 183);
            this.txtCalc.TabIndex = 1;
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Location = new System.Drawing.Point(41, 189);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(29, 12);
            this.lblCalc.TabIndex = 2;
            this.lblCalc.Text = "결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 410);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.txtCalc);
            this.Controls.Add(this.lblDan);
            this.Controls.Add(this.txtDan);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "구구단";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtDan;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Label lblCalc;
    }
}

