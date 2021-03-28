
namespace problem2
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.lblSurface = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(117, 36);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 21);
            this.txtRadius.TabIndex = 0;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(48, 39);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(41, 12);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "반지름";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(117, 112);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "계산하기";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(117, 180);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 21);
            this.txtVolume.TabIndex = 0;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(48, 183);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(29, 12);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "부피";
            this.lblVolume.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(117, 225);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(100, 21);
            this.txtSurface.TabIndex = 0;
            // 
            // lblSurface
            // 
            this.lblSurface.AutoSize = true;
            this.lblSurface.Location = new System.Drawing.Point(48, 228);
            this.lblSurface.Name = "lblSurface";
            this.lblSurface.Size = new System.Drawing.Size(41, 12);
            this.lblSurface.TabIndex = 1;
            this.lblSurface.Text = "표면적";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 329);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblSurface);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtRadius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.label2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.Label lblSurface;
    }
}

