
namespace week4_2
{
    partial class PointForm
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
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.lblPrint = new System.Windows.Forms.Label();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(33, 58);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 12);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X값";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(107, 55);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 21);
            this.txtX.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(35, 165);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "객체생성";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(33, 107);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 12);
            this.lblY.TabIndex = 0;
            this.lblY.Text = "Y값";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(107, 104);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 21);
            this.txtY.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(150, 165);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "좌표변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(272, 165);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "이동";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(33, 225);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(53, 12);
            this.lblPrint.TabIndex = 0;
            this.lblPrint.Text = "객체정보";
            this.lblPrint.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(107, 222);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(240, 21);
            this.txtPrint.TabIndex = 1;
            this.txtPrint.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 309);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Name = "PointForm";
            this.Text = "Point";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.TextBox txtPrint;
    }
}

