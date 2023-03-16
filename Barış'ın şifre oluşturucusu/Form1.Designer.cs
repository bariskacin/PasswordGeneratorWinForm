namespace Barış_ın_şifre_oluşturucusu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            lengthTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(136, 295);
            button1.Name = "button1";
            button1.Size = new Size(180, 94);
            button1.TabIndex = 0;
            button1.Text = "Şifre Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(136, 76);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(180, 27);
            lengthTextBox.TabIndex = 1;
            lengthTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ButtonHighlight;
            passwordTextBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(136, 196);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.ReadOnly = true;
            passwordTextBox.Size = new Size(180, 71);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 53);
            label1.Name = "label1";
            label1.Size = new Size(282, 20);
            label1.TabIndex = 3;
            label1.Text = "İstediğiniz şifrenin karakter sayısını giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 173);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "Şifreniz:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 415);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(lengthTextBox);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barış'ın şifre oluşturucusu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox lengthTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
    }
}