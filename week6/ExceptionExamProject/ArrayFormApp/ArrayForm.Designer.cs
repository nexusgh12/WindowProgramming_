
namespace ArrayFormApp
{
    partial class ArrayForm
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
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "배열 arr에 입력된 값 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(215, 58);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 21);
            this.txtIndex.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(14, 101);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "출력할 배열의 인덱스를 입력하세요";
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(125, 101);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(75, 23);
            this.btnPrintAll.TabIndex = 2;
            this.btnPrintAll.Text = "모두 출력";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "출력값 : ";
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(81, 142);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(241, 21);
            this.txtPrint.TabIndex = 1;
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 248);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArrayForm";
            this.Text = "배열 출력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrint;
    }
}

