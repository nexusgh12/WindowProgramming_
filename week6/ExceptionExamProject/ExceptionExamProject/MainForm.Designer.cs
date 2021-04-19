
namespace ExceptionExamProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력값 1:";
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(114, 73);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 21);
            this.txtInput1.TabIndex = 1;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(93, 155);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "나누기";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "입력값 2:";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(114, 115);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 21);
            this.txtInput2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "나눈 값:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(114, 198);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 21);
            this.txtOutput.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(42, 242);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(298, 64);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "입력값 1을 입력값 2로 나누어 결과를 출력하는 프로그램으로 입력한 값 2가 0일 겨우 나타나는 예외를 처리해 DIV/0 문자를 출력하시오";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "( 라벨속성 autosize = False )";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 337);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "예외처리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label5;
    }
}

