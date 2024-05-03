namespace UTS_PBO_2003
{
    partial class LOGIN_MHS
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
            label4 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 45);
            label1.Name = "label1";
            label1.Size = new Size(329, 43);
            label1.TabIndex = 0;
            label1.Text = "LOGIN MAHASISWA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, 150);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 5;
            label4.Text = "NIM:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(145, 249);
            label7.Name = "label7";
            label7.Size = new Size(123, 28);
            label7.TabIndex = 10;
            label7.Text = "PASSWORD:";
            // 
            // button1
            // 
            button1.Location = new Point(327, 142);
            button1.Name = "button1";
            button1.Size = new Size(204, 36);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(327, 241);
            button2.Name = "button2";
            button2.Size = new Size(204, 36);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GradientActiveCaption;
            button6.Location = new Point(633, 390);
            button6.Name = "button6";
            button6.Size = new Size(84, 27);
            button6.TabIndex = 13;
            button6.Text = "NEXT";
            button6.UseVisualStyleBackColor = false;
            // 
            // LOGIN_MHS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "LOGIN_MHS";
            Text = "LOGIN_MHS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button6;
    }
}