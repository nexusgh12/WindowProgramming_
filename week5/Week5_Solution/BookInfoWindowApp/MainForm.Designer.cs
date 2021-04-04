
namespace BookInfoWindowApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnOfS = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPages);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(94, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(195, 21);
            this.txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(94, 53);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 21);
            this.txtAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pages";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(94, 80);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(70, 21);
            this.txtPages.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(94, 107);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 21);
            this.txtISBN.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Publisher";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(94, 134);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(128, 21);
            this.txtPublisher.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 161);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 21);
            this.txtPrice.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Price";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(106, 268);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(128, 21);
            this.txtDiscount.TabIndex = 3;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(274, 268);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnDiscount.TabIndex = 1;
            this.btnDiscount.Text = "할인";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnOfS
            // 
            this.btnOfS.Location = new System.Drawing.Point(375, 268);
            this.btnOfS.Name = "btnOfS";
            this.btnOfS.Size = new System.Drawing.Size(75, 23);
            this.btnOfS.TabIndex = 1;
            this.btnOfS.Text = "품절";
            this.btnOfS.UseVisualStyleBackColor = true;
            this.btnOfS.Click += new System.EventHandler(this.btnOfS_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(37, 312);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(37, 354);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(413, 140);
            this.txtResult.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 520);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnOfS);
            this.Controls.Add(this.btnDiscount);
            this.Name = "MainForm";
            this.Text = "Ebook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnOfS;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtResult;
    }
}

