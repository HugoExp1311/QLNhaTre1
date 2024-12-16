namespace QLnhatre2
{
    partial class ThucDon
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtClassCode = new TextBox();
            txtDay = new TextBox();
            txtFood = new TextBox();
            btnUpdateActivity = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 34);
            label2.Name = "label2";
            label2.Size = new Size(298, 46);
            label2.TabIndex = 5;
            label2.Text = "Cập nhật thực đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 116);
            label1.MaximumSize = new Size(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 6;
            label1.Text = "Mã lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 184);
            label3.MaximumSize = new Size(100, 100);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 9;
            label3.Text = "Thứ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 252);
            label4.MaximumSize = new Size(100, 100);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 11;
            label4.Text = "Cập nhật";
            // 
            // txtClassCode
            // 
            txtClassCode.Location = new Point(144, 116);
            txtClassCode.Name = "txtClassCode";
            txtClassCode.Size = new Size(221, 31);
            txtClassCode.TabIndex = 12;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(144, 181);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(221, 31);
            txtDay.TabIndex = 13;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(144, 252);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(221, 31);
            txtFood.TabIndex = 14;
            // 
            // btnUpdateActivity
            // 
            btnUpdateActivity.Location = new Point(144, 313);
            btnUpdateActivity.Name = "btnUpdateActivity";
            btnUpdateActivity.Size = new Size(150, 47);
            btnUpdateActivity.TabIndex = 15;
            btnUpdateActivity.Text = "Xác nhận";
            btnUpdateActivity.UseVisualStyleBackColor = true;
            btnUpdateActivity.Click += btnUpdateActivity_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 122);
            label5.MaximumSize = new Size(100, 100);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 16;
            label5.Text = "Vd: L1A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 187);
            label6.MaximumSize = new Size(100, 100);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 17;
            label6.Text = "Vd: thứ_2";
            // 
            // ThucDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnUpdateActivity);
            Controls.Add(txtFood);
            Controls.Add(txtDay);
            Controls.Add(txtClassCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ThucDon";
            Text = "ThucDon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtClassCode;
        private TextBox txtDay;
        private TextBox txtFood;
        private Button btnUpdateActivity;
        private Label label5;
        private Label label6;
    }
}