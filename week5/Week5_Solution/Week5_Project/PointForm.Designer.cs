
namespace Week5_Project
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.btnMoveBy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(91, 25);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 21);
            this.txtX.TabIndex = 0;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(27, 34);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(29, 12);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X 값";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(89, 124);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "객체생성";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(91, 81);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 21);
            this.txtY.TabIndex = 0;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(27, 90);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(29, 12);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y 값";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(91, 168);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "정보출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(187, 168);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "모두이동";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(91, 211);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(251, 232);
            this.txtPrint.TabIndex = 0;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(27, 214);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(53, 12);
            this.lblPrint.TabIndex = 1;
            this.lblPrint.Text = "정보출력";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(187, 124);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "더하기";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(221, 25);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 21);
            this.txtX2.TabIndex = 0;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(221, 81);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 21);
            this.txtY2.TabIndex = 0;
            // 
            // btnMoveBy
            // 
            this.btnMoveBy.Location = new System.Drawing.Point(277, 124);
            this.btnMoveBy.Name = "btnMoveBy";
            this.btnMoveBy.Size = new System.Drawing.Size(75, 23);
            this.btnMoveBy.TabIndex = 2;
            this.btnMoveBy.Text = "좌표이동";
            this.btnMoveBy.UseVisualStyleBackColor = true;
            this.btnMoveBy.Click += new System.EventHandler(this.btnMoveBy_Click);
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 455);
            this.Controls.Add(this.btnMoveBy);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "PointForm";
            this.Text = "PointExam";
            this.Load += new System.EventHandler(this.PointForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Button btnMoveBy;
    }
}

