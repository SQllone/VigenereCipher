namespace VigenereCipher
{
    partial class regForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regForm));
            this.regButton = new System.Windows.Forms.Button();
            this.regPassBox = new System.Windows.Forms.TextBox();
            this.regLogBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regErrorText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(87, 322);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(161, 41);
            this.regButton.TabIndex = 11;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // regPassBox
            // 
            this.regPassBox.Location = new System.Drawing.Point(87, 238);
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.Size = new System.Drawing.Size(161, 20);
            this.regPassBox.TabIndex = 8;
            this.regPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regPassBox.UseSystemPasswordChar = true;
            this.regPassBox.Enter += new System.EventHandler(this.regPassBox_Enter);
            this.regPassBox.Leave += new System.EventHandler(this.regPassBox_Leave);
            // 
            // regLogBox
            // 
            this.regLogBox.Location = new System.Drawing.Point(87, 160);
            this.regLogBox.Name = "regLogBox";
            this.regLogBox.Size = new System.Drawing.Size(161, 20);
            this.regLogBox.TabIndex = 7;
            this.regLogBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regLogBox.Enter += new System.EventHandler(this.regLogBox_Enter);
            this.regLogBox.Leave += new System.EventHandler(this.regLogBox_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 100);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VigenereCipher.Properties.Resources.lockImg;
            this.pictureBox2.Location = new System.Drawing.Point(149, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VigenereCipher.Properties.Resources.newUserImg;
            this.pictureBox1.Location = new System.Drawing.Point(149, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // regErrorText
            // 
            this.regErrorText.AutoSize = true;
            this.regErrorText.ForeColor = System.Drawing.Color.Red;
            this.regErrorText.Location = new System.Drawing.Point(108, 278);
            this.regErrorText.Name = "regErrorText";
            this.regErrorText.Size = new System.Drawing.Size(120, 26);
            this.regErrorText.TabIndex = 13;
            this.regErrorText.Text = "Ошибка регистрации! \r\n        Логин занят!";
            this.regErrorText.Visible = false;
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.regErrorText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regPassBox);
            this.Controls.Add(this.regLogBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "regForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox regPassBox;
        private System.Windows.Forms.TextBox regLogBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label regErrorText;
    }
}