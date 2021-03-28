
namespace P_1
{
    partial class MainForm
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
            this.btnSwap = new System.Windows.Forms.Button();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(202, 90);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 0;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Location = new System.Drawing.Point(26, 47);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(45, 12);
            this.lblValue1.TabIndex = 1;
            this.lblValue1.Text = "value 1";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(92, 38);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 21);
            this.txtValue1.TabIndex = 2;
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(244, 47);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(45, 12);
            this.lblValue2.TabIndex = 1;
            this.lblValue2.Text = "value 2";
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(310, 38);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 21);
            this.txtValue2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 188);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.btnSwap);
            this.Name = "Form1";
            this.Text = "Swap App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.TextBox txtValue2;
    }
}

