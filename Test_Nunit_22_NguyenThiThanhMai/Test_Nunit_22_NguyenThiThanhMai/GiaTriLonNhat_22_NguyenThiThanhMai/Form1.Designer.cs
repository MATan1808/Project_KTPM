namespace GiaTriLonNhat_22_NguyenThiThanhMai
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txta_22_NguyenThiThanhMai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_22_NguyenThiThanhMai = new System.Windows.Forms.TextBox();
            this.btn_22_NguyenThiThanhMai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mảng n :";
            // 
            // txta_22_NguyenThiThanhMai
            // 
            this.txta_22_NguyenThiThanhMai.Location = new System.Drawing.Point(328, 89);
            this.txta_22_NguyenThiThanhMai.Name = "txta_22_NguyenThiThanhMai";
            this.txta_22_NguyenThiThanhMai.Size = new System.Drawing.Size(100, 22);
            this.txta_22_NguyenThiThanhMai.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lớn nhất :";
            // 
            // txtb_22_NguyenThiThanhMai
            // 
            this.txtb_22_NguyenThiThanhMai.Location = new System.Drawing.Point(328, 154);
            this.txtb_22_NguyenThiThanhMai.Name = "txtb_22_NguyenThiThanhMai";
            this.txtb_22_NguyenThiThanhMai.Size = new System.Drawing.Size(100, 22);
            this.txtb_22_NguyenThiThanhMai.TabIndex = 3;
            // 
            // btn_22_NguyenThiThanhMai
            // 
            this.btn_22_NguyenThiThanhMai.Location = new System.Drawing.Point(265, 245);
            this.btn_22_NguyenThiThanhMai.Name = "btn_22_NguyenThiThanhMai";
            this.btn_22_NguyenThiThanhMai.Size = new System.Drawing.Size(98, 45);
            this.btn_22_NguyenThiThanhMai.TabIndex = 4;
            this.btn_22_NguyenThiThanhMai.Text = "Tìm số lớn nhất";
            this.btn_22_NguyenThiThanhMai.UseVisualStyleBackColor = true;
            this.btn_22_NguyenThiThanhMai.Click += new System.EventHandler(this.btn_22_NguyenThiThanhMai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_22_NguyenThiThanhMai);
            this.Controls.Add(this.txtb_22_NguyenThiThanhMai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta_22_NguyenThiThanhMai);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta_22_NguyenThiThanhMai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_22_NguyenThiThanhMai;
        private System.Windows.Forms.Button btn_22_NguyenThiThanhMai;
    }
}

