namespace C__TINH_SO_TIEN_LAI_SAU_20_NĂM
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
            this.lblnhapsotien = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.lblnhaplaisuat = new System.Windows.Forms.Label();
            this.lblnhapsonam = new System.Windows.Forms.Label();
            this.txtsonam = new System.Windows.Forms.TextBox();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.lsbketqua = new System.Windows.Forms.ListBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.lblketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnhapsotien
            // 
            this.lblnhapsotien.AutoSize = true;
            this.lblnhapsotien.Location = new System.Drawing.Point(114, 48);
            this.lblnhapsotien.Name = "lblnhapsotien";
            this.lblnhapsotien.Size = new System.Drawing.Size(65, 13);
            this.lblnhapsotien.TabIndex = 0;
            this.lblnhapsotien.Text = "NHẬP TIỀN";
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(206, 41);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(100, 20);
            this.txtsotien.TabIndex = 1;
            // 
            // lblnhaplaisuat
            // 
            this.lblnhaplaisuat.AutoSize = true;
            this.lblnhaplaisuat.Location = new System.Drawing.Point(114, 102);
            this.lblnhaplaisuat.Name = "lblnhaplaisuat";
            this.lblnhaplaisuat.Size = new System.Drawing.Size(56, 13);
            this.lblnhaplaisuat.TabIndex = 2;
            this.lblnhaplaisuat.Text = "NHẬP LÃI";
            this.lblnhaplaisuat.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblnhapsonam
            // 
            this.lblnhapsonam.AutoSize = true;
            this.lblnhapsonam.Location = new System.Drawing.Point(114, 169);
            this.lblnhapsonam.Name = "lblnhapsonam";
            this.lblnhapsonam.Size = new System.Drawing.Size(64, 13);
            this.lblnhapsonam.TabIndex = 3;
            this.lblnhapsonam.Text = "NHẬP NĂM";
            // 
            // txtsonam
            // 
            this.txtsonam.Location = new System.Drawing.Point(206, 162);
            this.txtsonam.Name = "txtsonam";
            this.txtsonam.Size = new System.Drawing.Size(100, 20);
            this.txtsonam.TabIndex = 4;
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Location = new System.Drawing.Point(206, 95);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(100, 20);
            this.txtlaisuat.TabIndex = 4;
            // 
            // lsbketqua
            // 
            this.lsbketqua.FormattingEnabled = true;
            this.lsbketqua.Location = new System.Drawing.Point(282, 215);
            this.lsbketqua.Name = "lsbketqua";
            this.lsbketqua.Size = new System.Drawing.Size(283, 121);
            this.lsbketqua.TabIndex = 5;
            this.lsbketqua.SelectedIndexChanged += new System.EventHandler(this.lsbketqua_SelectedIndexChanged);
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(500, 367);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(106, 51);
            this.btntinh.TabIndex = 6;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(114, 215);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(54, 13);
            this.lblketqua.TabIndex = 7;
            this.lblketqua.Text = "KẾT QUẢ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lsbketqua);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.txtsonam);
            this.Controls.Add(this.lblnhapsonam);
            this.Controls.Add(this.lblnhaplaisuat);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.lblnhapsotien);
            this.Name = "Form1";
            this.Text = "g";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhapsotien;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label lblnhaplaisuat;
        private System.Windows.Forms.Label lblnhapsonam;
        private System.Windows.Forms.TextBox txtsonam;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.ListBox lsbketqua;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label lblketqua;
    }
}

