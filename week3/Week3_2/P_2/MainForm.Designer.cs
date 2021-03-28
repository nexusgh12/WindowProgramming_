
namespace P_2
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblInt1 = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblInt2 = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(95, 151);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "비교하기";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblInt1
            // 
            this.lblInt1.AutoSize = true;
            this.lblInt1.Location = new System.Drawing.Point(37, 51);
            this.lblInt1.Name = "lblInt1";
            this.lblInt1.Size = new System.Drawing.Size(57, 12);
            this.lblInt1.TabIndex = 1;
            this.lblInt1.Text = "정수 입력";
            this.lblInt1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(120, 48);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 21);
            this.txtValue1.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(118, 202);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 3;
            // 
            // lblInt2
            // 
            this.lblInt2.AutoSize = true;
            this.lblInt2.Location = new System.Drawing.Point(37, 94);
            this.lblInt2.Name = "lblInt2";
            this.lblInt2.Size = new System.Drawing.Size(57, 12);
            this.lblInt2.TabIndex = 1;
            this.lblInt2.Text = "정수 입력";
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(120, 91);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 21);
            this.txtValue2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 345);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.lblInt2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblInt1);
            this.Controls.Add(this.btnCompare);
            this.Name = "MainForm";
            this.Text = "크기 비교";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblInt1;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblInt2;
        private System.Windows.Forms.TextBox txtValue2;
    }
}

