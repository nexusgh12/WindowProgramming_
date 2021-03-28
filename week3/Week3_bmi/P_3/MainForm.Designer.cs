
namespace P_3
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblStandard = new System.Windows.Forms.Label();
            this.txtStandard = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.lblFat = new System.Windows.Forms.Label();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(21, 37);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(17, 12);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "키";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(112, 113);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "확인";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(112, 34);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(164, 21);
            this.txtHeight.TabIndex = 2;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(21, 64);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 12);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "몸무게";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(112, 61);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(164, 21);
            this.txtWeight.TabIndex = 2;
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Location = new System.Drawing.Point(21, 173);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(53, 12);
            this.lblStandard.TabIndex = 0;
            this.lblStandard.Text = "표준체중";
            // 
            // txtStandard
            // 
            this.txtStandard.Location = new System.Drawing.Point(112, 170);
            this.txtStandard.Name = "txtStandard";
            this.txtStandard.Size = new System.Drawing.Size(164, 21);
            this.txtStandard.TabIndex = 2;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(21, 213);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(85, 12);
            this.lblBMI.TabIndex = 0;
            this.lblBMI.Text = "비만지수(BMI)";
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(112, 210);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(164, 21);
            this.txtBMI.TabIndex = 2;
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(21, 269);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(41, 12);
            this.lblFat.TabIndex = 0;
            this.lblFat.Text = "비만도";
            // 
            // txtFat
            // 
            this.txtFat.Location = new System.Drawing.Point(112, 266);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(164, 21);
            this.txtFat.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 379);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.txtStandard);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblHeight);
            this.Name = "MainForm";
            this.Text = "비만도 측정기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.TextBox txtStandard;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.TextBox txtFat;
    }
}

