namespace UTS_PBO_2003
{
    partial class WELCOME
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

        private Label label1;
    namespace WELCOME
    {
        public partical class form1 : Form
        {
            public form1()
            {
                InitializeComputer();
            }
            private void buttonclick(MAHASISWA, DOSEN)
            { 
                c
            }
        }

    }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 61);
            label1.Name = "label1";
            label1.Size = new Size(184, 43);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(137, 257);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 32);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "DOSEN";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(137, 169);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 32);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "MAHASISWA";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(628, 390);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 4;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = false;
            // 
            // WELCOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(label1);
            Name = "WELCOME";
            Text = "WELCOME";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
    }
}