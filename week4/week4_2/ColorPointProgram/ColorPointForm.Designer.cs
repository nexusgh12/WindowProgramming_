
namespace ColorPointProgram
{
    partial class ColorPointForm
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnChangeX = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnChangeY = new System.Windows.Forms.Button();
            this.btnChangeZ = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtXPrint = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYPrint = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZPrint = new System.Windows.Forms.TextBox();
            this.txtColorPrint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X :";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(80, 99);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 21);
            this.txtX.TabIndex = 1;
            // 
            // btnChangeX
            // 
            this.btnChangeX.Location = new System.Drawing.Point(229, 99);
            this.btnChangeX.Name = "btnChangeX";
            this.btnChangeX.Size = new System.Drawing.Size(63, 23);
            this.btnChangeX.TabIndex = 2;
            this.btnChangeX.Text = ">>";
            this.btnChangeX.UseVisualStyleBackColor = true;
            this.btnChangeX.Click += new System.EventHandler(this.btnChangeX_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "좌표 생성 및 변경";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y ; ";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(80, 144);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 21);
            this.txtY.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Z : ";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(80, 187);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 21);
            this.txtZ.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(80, 236);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 21);
            this.txtColor.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(81, 289);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "객체 생성";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(218, 289);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(357, 289);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "이동";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnChangeY
            // 
            this.btnChangeY.Location = new System.Drawing.Point(229, 146);
            this.btnChangeY.Name = "btnChangeY";
            this.btnChangeY.Size = new System.Drawing.Size(63, 23);
            this.btnChangeY.TabIndex = 2;
            this.btnChangeY.Text = ">>";
            this.btnChangeY.UseVisualStyleBackColor = true;
            this.btnChangeY.Click += new System.EventHandler(this.btnChangeY_Click);
            // 
            // btnChangeZ
            // 
            this.btnChangeZ.Location = new System.Drawing.Point(229, 189);
            this.btnChangeZ.Name = "btnChangeZ";
            this.btnChangeZ.Size = new System.Drawing.Size(63, 23);
            this.btnChangeZ.TabIndex = 2;
            this.btnChangeZ.Text = ">>";
            this.btnChangeZ.UseVisualStyleBackColor = true;
            this.btnChangeZ.Click += new System.EventHandler(this.btnChangeZ_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(229, 236);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(63, 23);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = ">>";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "X :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "현재 좌표 정보";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Y ; ";
            // 
            // txtXPrint
            // 
            this.txtXPrint.Location = new System.Drawing.Point(375, 101);
            this.txtXPrint.Name = "txtXPrint";
            this.txtXPrint.Size = new System.Drawing.Size(100, 21);
            this.txtXPrint.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Z : ";
            // 
            // txtYPrint
            // 
            this.txtYPrint.Location = new System.Drawing.Point(375, 146);
            this.txtYPrint.Name = "txtYPrint";
            this.txtYPrint.Size = new System.Drawing.Size(100, 21);
            this.txtYPrint.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Color";
            // 
            // txtZPrint
            // 
            this.txtZPrint.Location = new System.Drawing.Point(375, 189);
            this.txtZPrint.Name = "txtZPrint";
            this.txtZPrint.Size = new System.Drawing.Size(100, 21);
            this.txtZPrint.TabIndex = 1;
            // 
            // txtColorPrint
            // 
            this.txtColorPrint.Location = new System.Drawing.Point(375, 238);
            this.txtColorPrint.Name = "txtColorPrint";
            this.txtColorPrint.Size = new System.Drawing.Size(100, 21);
            this.txtColorPrint.TabIndex = 1;
            // 
            // ColorPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 379);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.btnChangeY);
            this.Controls.Add(this.btnChangeZ);
            this.Controls.Add(this.btnChangeX);
            this.Controls.Add(this.txtColorPrint);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtZPrint);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYPrint);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXPrint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorPointForm";
            this.Text = "3D Color Point";
            this.Load += new System.EventHandler(this.ColorPointForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnChangeX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnChangeY;
        private System.Windows.Forms.Button btnChangeZ;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXPrint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYPrint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtZPrint;
        private System.Windows.Forms.TextBox txtColorPrint;
    }
}

