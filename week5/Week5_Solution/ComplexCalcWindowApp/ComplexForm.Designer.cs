
namespace ComplexCalcWindowApp
{
    partial class ComplexForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReal1 = new System.Windows.Forms.TextBox();
            this.ComplexA = new System.Windows.Forms.GroupBox();
            this.txtImaginary1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComplexB = new System.Windows.Forms.GroupBox();
            this.txtImaginary2 = new System.Windows.Forms.TextBox();
            this.txtReal2 = new System.Windows.Forms.TextBox();
            this.ComplexC = new System.Windows.Forms.GroupBox();
            this.txtImaginaryResult = new System.Windows.Forms.TextBox();
            this.txtRealResult = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.ComplexA.SuspendLayout();
            this.ComplexB.SuspendLayout();
            this.ComplexC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "실수부";
            // 
            // txtReal1
            // 
            this.txtReal1.Location = new System.Drawing.Point(37, 36);
            this.txtReal1.Name = "txtReal1";
            this.txtReal1.Size = new System.Drawing.Size(100, 21);
            this.txtReal1.TabIndex = 2;
            // 
            // ComplexA
            // 
            this.ComplexA.Controls.Add(this.txtImaginary1);
            this.ComplexA.Controls.Add(this.txtReal1);
            this.ComplexA.Location = new System.Drawing.Point(81, 26);
            this.ComplexA.Name = "ComplexA";
            this.ComplexA.Size = new System.Drawing.Size(174, 164);
            this.ComplexA.TabIndex = 3;
            this.ComplexA.TabStop = false;
            this.ComplexA.Text = "ComplexA";
            // 
            // txtImaginary1
            // 
            this.txtImaginary1.Location = new System.Drawing.Point(37, 119);
            this.txtImaginary1.Name = "txtImaginary1";
            this.txtImaginary1.Size = new System.Drawing.Size(100, 21);
            this.txtImaginary1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "허수부";
            // 
            // ComplexB
            // 
            this.ComplexB.Controls.Add(this.txtImaginary2);
            this.ComplexB.Controls.Add(this.txtReal2);
            this.ComplexB.Location = new System.Drawing.Point(273, 26);
            this.ComplexB.Name = "ComplexB";
            this.ComplexB.Size = new System.Drawing.Size(174, 164);
            this.ComplexB.TabIndex = 3;
            this.ComplexB.TabStop = false;
            this.ComplexB.Text = "ComplexB";
            // 
            // txtImaginary2
            // 
            this.txtImaginary2.Location = new System.Drawing.Point(37, 119);
            this.txtImaginary2.Name = "txtImaginary2";
            this.txtImaginary2.Size = new System.Drawing.Size(100, 21);
            this.txtImaginary2.TabIndex = 2;
            // 
            // txtReal2
            // 
            this.txtReal2.Location = new System.Drawing.Point(37, 36);
            this.txtReal2.Name = "txtReal2";
            this.txtReal2.Size = new System.Drawing.Size(100, 21);
            this.txtReal2.TabIndex = 2;
            // 
            // ComplexC
            // 
            this.ComplexC.Controls.Add(this.txtImaginaryResult);
            this.ComplexC.Controls.Add(this.txtRealResult);
            this.ComplexC.Location = new System.Drawing.Point(464, 26);
            this.ComplexC.Name = "ComplexC";
            this.ComplexC.Size = new System.Drawing.Size(174, 164);
            this.ComplexC.TabIndex = 3;
            this.ComplexC.TabStop = false;
            this.ComplexC.Text = "ComplexC";
            // 
            // txtImaginaryResult
            // 
            this.txtImaginaryResult.Location = new System.Drawing.Point(37, 119);
            this.txtImaginaryResult.Name = "txtImaginaryResult";
            this.txtImaginaryResult.Size = new System.Drawing.Size(100, 21);
            this.txtImaginaryResult.TabIndex = 2;
            // 
            // txtRealResult
            // 
            this.txtRealResult.Location = new System.Drawing.Point(37, 36);
            this.txtRealResult.Name = "txtRealResult";
            this.txtRealResult.Size = new System.Drawing.Size(100, 21);
            this.txtRealResult.TabIndex = 2;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(350, 214);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // ComplexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 279);
            this.Controls.Add(this.ComplexC);
            this.Controls.Add(this.ComplexB);
            this.Controls.Add(this.ComplexA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnAdd);
            this.Name = "ComplexForm";
            this.Text = "복소수 계산기";
            this.ComplexA.ResumeLayout(false);
            this.ComplexA.PerformLayout();
            this.ComplexB.ResumeLayout(false);
            this.ComplexB.PerformLayout();
            this.ComplexC.ResumeLayout(false);
            this.ComplexC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReal1;
        private System.Windows.Forms.GroupBox ComplexA;
        private System.Windows.Forms.TextBox txtImaginary1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ComplexB;
        private System.Windows.Forms.TextBox txtImaginary2;
        private System.Windows.Forms.TextBox txtReal2;
        private System.Windows.Forms.GroupBox ComplexC;
        private System.Windows.Forms.TextBox txtImaginaryResult;
        private System.Windows.Forms.TextBox txtRealResult;
        private System.Windows.Forms.Button btnMultiply;
    }
}

