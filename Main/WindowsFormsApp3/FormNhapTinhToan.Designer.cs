namespace WindowsFormsApp3
{
    partial class FormNhapTinhToan
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ngayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.ngayBatDau = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTienNuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTienDien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaCanHo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(238, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 37);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(238, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 37);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.CustomFormat = "yyy-MM-dd";
            this.ngayKetThuc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayKetThuc.Location = new System.Drawing.Point(461, 408);
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Size = new System.Drawing.Size(294, 39);
            this.ngayKetThuc.TabIndex = 31;
            this.ngayKetThuc.ValueChanged += new System.EventHandler(this.ngayKetThuc_ValueChanged);
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.CustomFormat = "yyy-MM-dd";
            this.ngayBatDau.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayBatDau.Location = new System.Drawing.Point(461, 357);
            this.ngayBatDau.MinDate = new System.DateTime(2024, 5, 4, 0, 0, 0, 0);
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.Size = new System.Drawing.Size(294, 39);
            this.ngayBatDau.TabIndex = 30;
            this.ngayBatDau.ValueChanged += new System.EventHandler(this.ngayBatDau_ValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(487, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 59);
            this.button2.TabIndex = 33;
            this.button2.Text = "Tính tổng tiền";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(295, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbTienNuoc
            // 
            this.tbTienNuoc.Font = new System.Drawing.Font("Times New Roman", 19.8F);
            this.tbTienNuoc.Location = new System.Drawing.Point(461, 282);
            this.tbTienNuoc.Multiline = true;
            this.tbTienNuoc.Name = "tbTienNuoc";
            this.tbTienNuoc.Size = new System.Drawing.Size(143, 39);
            this.tbTienNuoc.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(238, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số m3 nước";
            // 
            // tbTienDien
            // 
            this.tbTienDien.Font = new System.Drawing.Font("Times New Roman", 19.8F);
            this.tbTienDien.Location = new System.Drawing.Point(461, 222);
            this.tbTienDien.Multiline = true;
            this.tbTienDien.Name = "tbTienDien";
            this.tbTienDien.Size = new System.Drawing.Size(143, 39);
            this.tbTienDien.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(238, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Số kwh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(238, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(370, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 49);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập các số liệu";
            // 
            // tbMaCanHo
            // 
            this.tbMaCanHo.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMaCanHo.Location = new System.Drawing.Point(461, 162);
            this.tbMaCanHo.Multiline = true;
            this.tbMaCanHo.Name = "tbMaCanHo";
            this.tbMaCanHo.Size = new System.Drawing.Size(294, 39);
            this.tbMaCanHo.TabIndex = 23;
            this.tbMaCanHo.TextChanged += new System.EventHandler(this.tbMaCanHo_TextChanged);
            // 
            // FormNhapTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(993, 597);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ngayKetThuc);
            this.Controls.Add(this.ngayBatDau);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTienNuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTienDien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaCanHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapTinhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhapTinhToan";
            this.Load += new System.EventHandler(this.FormNhapTinhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngayKetThuc;
        private System.Windows.Forms.DateTimePicker ngayBatDau;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTienNuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTienDien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaCanHo;
    }
}