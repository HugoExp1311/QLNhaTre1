namespace QLnhatre2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            kếtNốiToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            bảngTeacherToolStripMenuItem = new ToolStripMenuItem();
            danhSachLớpToolStripMenuItem = new ToolStripMenuItem();
            lớpLA1ToolStripMenuItem = new ToolStripMenuItem();
            lớpLToolStripMenuItem = new ToolStripMenuItem();
            thựcĐơnToolStripMenuItem = new ToolStripMenuItem();
            lớpL1AToolStripMenuItem = new ToolStripMenuItem();
            lớpL1ToolStripMenuItem = new ToolStripMenuItem();
            buttonĐiểm_danh = new Button();
            Hoạt_động = new Button();
            thucdon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(233, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 322);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1033, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { kếtNốiToolStripMenuItem, thựcĐơnToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(52, 29);
            toolStripMenuItem1.Text = "File";
            // 
            // kếtNốiToolStripMenuItem
            // 
            kếtNốiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentToolStripMenuItem, bảngTeacherToolStripMenuItem, danhSachLớpToolStripMenuItem });
            kếtNốiToolStripMenuItem.Name = "kếtNốiToolStripMenuItem";
            kếtNốiToolStripMenuItem.Size = new Size(216, 30);
            kếtNốiToolStripMenuItem.Text = "Kết nối";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(211, 30);
            studentToolStripMenuItem.Text = "Bảng Student";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // bảngTeacherToolStripMenuItem
            // 
            bảngTeacherToolStripMenuItem.Name = "bảngTeacherToolStripMenuItem";
            bảngTeacherToolStripMenuItem.Size = new Size(211, 30);
            bảngTeacherToolStripMenuItem.Text = "Bảng Teacher";
            bảngTeacherToolStripMenuItem.Click += bảngTeacherToolStripMenuItem_Click;
            // 
            // danhSachLớpToolStripMenuItem
            // 
            danhSachLớpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lớpLA1ToolStripMenuItem, lớpLToolStripMenuItem });
            danhSachLớpToolStripMenuItem.Name = "danhSachLớpToolStripMenuItem";
            danhSachLớpToolStripMenuItem.Size = new Size(211, 30);
            danhSachLớpToolStripMenuItem.Text = "Danh sách lớp";
            danhSachLớpToolStripMenuItem.Click += danhSachLớpToolStripMenuItem_Click;
            // 
            // lớpLA1ToolStripMenuItem
            // 
            lớpLA1ToolStripMenuItem.Name = "lớpLA1ToolStripMenuItem";
            lớpLA1ToolStripMenuItem.Size = new Size(164, 30);
            lớpLA1ToolStripMenuItem.Text = "Lớp LA1";
            lớpLA1ToolStripMenuItem.Click += lớpLA1ToolStripMenuItem_Click;
            // 
            // lớpLToolStripMenuItem
            // 
            lớpLToolStripMenuItem.Name = "lớpLToolStripMenuItem";
            lớpLToolStripMenuItem.Size = new Size(164, 30);
            lớpLToolStripMenuItem.Text = "Lớp LB1";
            lớpLToolStripMenuItem.Click += lớpLToolStripMenuItem_Click;
            // 
            // thựcĐơnToolStripMenuItem
            // 
            thựcĐơnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lớpL1AToolStripMenuItem, lớpL1ToolStripMenuItem });
            thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            thựcĐơnToolStripMenuItem.Size = new Size(216, 30);
            thựcĐơnToolStripMenuItem.Text = "Hoạt động lớp";
            thựcĐơnToolStripMenuItem.Click += thựcĐơnToolStripMenuItem_Click;
            // 
            // lớpL1AToolStripMenuItem
            // 
            lớpL1AToolStripMenuItem.Name = "lớpL1AToolStripMenuItem";
            lớpL1AToolStripMenuItem.Size = new Size(163, 30);
            lớpL1AToolStripMenuItem.Text = "Lớp L1A";
            lớpL1AToolStripMenuItem.Click += lớpL1AToolStripMenuItem_Click;
            // 
            // lớpL1ToolStripMenuItem
            // 
            lớpL1ToolStripMenuItem.Name = "lớpL1ToolStripMenuItem";
            lớpL1ToolStripMenuItem.Size = new Size(163, 30);
            lớpL1ToolStripMenuItem.Text = "Lớp L1B";
            lớpL1ToolStripMenuItem.Click += lớpL1ToolStripMenuItem_Click;
            // 
            // buttonĐiểm_danh
            // 
            buttonĐiểm_danh.Location = new Point(36, 64);
            buttonĐiểm_danh.Name = "buttonĐiểm_danh";
            buttonĐiểm_danh.Size = new Size(138, 54);
            buttonĐiểm_danh.TabIndex = 2;
            buttonĐiểm_danh.Text = "Điểm danh";
            buttonĐiểm_danh.UseVisualStyleBackColor = true;
            buttonĐiểm_danh.Visible = false;
            buttonĐiểm_danh.Click += buttonĐiểm_danh_Click;
            // 
            // Hoạt_động
            // 
            Hoạt_động.Location = new Point(36, 67);
            Hoạt_động.Name = "Hoạt_động";
            Hoạt_động.Size = new Size(138, 49);
            Hoạt_động.TabIndex = 3;
            Hoạt_động.Text = "Hoạt động";
            Hoạt_động.UseVisualStyleBackColor = true;
            Hoạt_động.Visible = false;
            Hoạt_động.Click += Hoạt_động_Click;
            // 
            // thucdon
            // 
            thucdon.Location = new Point(36, 157);
            thucdon.Name = "thucdon";
            thucdon.Size = new Size(138, 49);
            thucdon.TabIndex = 4;
            thucdon.Text = "Thực đơn";
            thucdon.UseVisualStyleBackColor = true;
            thucdon.Visible = false;
            thucdon.Click += thucdon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 450);
            Controls.Add(thucdon);
            Controls.Add(Hoạt_động);
            Controls.Add(buttonĐiểm_danh);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem kếtNốiToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem bảngTeacherToolStripMenuItem;
        private ToolStripMenuItem danhSachLớpToolStripMenuItem;
        private ToolStripMenuItem lớpLA1ToolStripMenuItem;
        private ToolStripMenuItem lớpLToolStripMenuItem;
        private ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private Button buttonĐiểm_danh;
        private ToolStripMenuItem lớpL1AToolStripMenuItem;
        private ToolStripMenuItem lớpL1ToolStripMenuItem;
        private Button Hoạt_động;
        private Button thucdon;
    }
}
