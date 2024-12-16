namespace QLnhatre2
{
    partial class FormDangNhap
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label3 = new Label();
            button2 = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 39);
            label2.Name = "label2";
            label2.Size = new Size(213, 46);
            label2.TabIndex = 4;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(270, 128);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(229, 47);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(270, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 47);
            txtPassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 141);
            label1.MaximumSize = new Size(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 7;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 215);
            label3.MaximumSize = new Size(100, 100);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 8;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(270, 278);
            button2.Name = "button2";
            button2.Size = new Size(150, 44);
            button2.TabIndex = 9;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(459, 285);
            lblMessage.MaximumSize = new Size(100, 100);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(99, 28);
            lblMessage.TabIndex = 10;
            lblMessage.Text = "Username";
            lblMessage.Visible = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label3;
        private Button button2;
        private Label lblMessage;
    }
}