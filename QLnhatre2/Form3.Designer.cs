namespace QLnhatre2
{
    partial class Form3
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
            txtClassCode = new TextBox();
            btnUpdateActivity = new Button();
            label3 = new Label();
            txtDay = new TextBox();
            label4 = new Label();
            txtActivity = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 32);
            label2.Name = "label2";
            label2.Size = new Size(319, 46);
            label2.TabIndex = 4;
            label2.Text = "Cập nhật hoạt động";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 100);
            label1.MaximumSize = new Size(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 5;
            label1.Text = "Mã lớp";
            // 
            // txtClassCode
            // 
            txtClassCode.Location = new Point(120, 97);
            txtClassCode.Name = "txtClassCode";
            txtClassCode.Size = new Size(221, 31);
            txtClassCode.TabIndex = 6;
            // 
            // btnUpdateActivity
            // 
            btnUpdateActivity.Location = new Point(55, 299);
            btnUpdateActivity.Name = "btnUpdateActivity";
            btnUpdateActivity.Size = new Size(150, 47);
            btnUpdateActivity.TabIndex = 7;
            btnUpdateActivity.Text = "Xác nhận";
            btnUpdateActivity.UseVisualStyleBackColor = true;
            btnUpdateActivity.Click += btnUpdateActivity_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 159);
            label3.MaximumSize = new Size(100, 100);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 8;
            label3.Text = "Thứ";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(120, 159);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(221, 31);
            txtDay.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 234);
            label4.MaximumSize = new Size(100, 100);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 10;
            label4.Text = "Cập nhật";
            // 
            // txtActivity
            // 
            txtActivity.Location = new Point(120, 234);
            txtActivity.Name = "txtActivity";
            txtActivity.Size = new Size(221, 31);
            txtActivity.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtActivity);
            Controls.Add(label4);
            Controls.Add(txtDay);
            Controls.Add(label3);
            Controls.Add(btnUpdateActivity);
            Controls.Add(txtClassCode);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtClassCode;
        private Button btnUpdateActivity;
        private Label label3;
        private TextBox txtDay;
        private Label label4;
        private TextBox txtActivity;
    }
}