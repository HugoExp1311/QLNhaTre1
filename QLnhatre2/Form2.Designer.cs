﻿namespace QLnhatre2
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 86);
            label1.MaximumSize = new Size(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã trẻ em";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(324, 78);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 2;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 27);
            label2.Name = "label2";
            label2.Size = new Size(215, 46);
            label2.TabIndex = 3;
            label2.Text = "ĐÁNH VẮNG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 173);
            label3.Name = "label3";
            label3.Size = new Size(204, 46);
            label3.TabIndex = 4;
            label3.Text = "ĐIỂM DANH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 241);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 5;
            label4.Text = "Mã trẻ em";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 31);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(324, 234);
            button2.Name = "button2";
            button2.Size = new Size(150, 44);
            button2.TabIndex = 7;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
    }
}