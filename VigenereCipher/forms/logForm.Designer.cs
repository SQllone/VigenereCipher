namespace VigenereCipher
{
    partial class logForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logLogBox = new System.Windows.Forms.TextBox();
            this.logPassBox = new System.Windows.Forms.TextBox();
            this.logButton = new System.Windows.Forms.Button();
            this.goRegButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logErrorText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logLogBox
            // 
            this.logLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logLogBox.Location = new System.Drawing.Point(87, 160);
            this.logLogBox.Name = "logLogBox";
            this.logLogBox.Size = new System.Drawing.Size(161, 20);
            this.logLogBox.TabIndex = 1;
            this.logLogBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logLogBox.Enter += new System.EventHandler(this.logLogBox_Enter);
            this.logLogBox.Leave += new System.EventHandler(this.logLogBox_Leave);
            // 
            // logPassBox
            // 
            this.logPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logPassBox.Location = new System.Drawing.Point(87, 238);
            this.logPassBox.Name = "logPassBox";
            this.logPassBox.Size = new System.Drawing.Size(161, 20);
            this.logPassBox.TabIndex = 2;
            this.logPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logPassBox.Enter += new System.EventHandler(this.logPassBox_Enter);
            this.logPassBox.Leave += new System.EventHandler(this.logPassBox_Leave);
            // 
            // logButton
            // 
            this.logButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.Location = new System.Drawing.Point(87, 302);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(161, 41);
            this.logButton.TabIndex = 5;
            this.logButton.Text = "Вход";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // goRegButton
            // 
            this.goRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goRegButton.Location = new System.Drawing.Point(87, 349);
            this.goRegButton.Name = "goRegButton";
            this.goRegButton.Size = new System.Drawing.Size(161, 41);
            this.goRegButton.TabIndex = 6;
            this.goRegButton.Text = "Регистрация";
            this.goRegButton.UseVisualStyleBackColor = true;
            this.goRegButton.Click += new System.EventHandler(this.goRegButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::VigenereCipher.Properties.Resources.lockImg;
            this.pictureBox2.Location = new System.Drawing.Point(149, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::VigenereCipher.Properties.Resources.userImg;
            this.pictureBox1.Location = new System.Drawing.Point(149, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // logErrorText
            // 
            this.logErrorText.Location = new System.Drawing.Point(87, 273);
            this.logErrorText.Name = "logErrorText";
            this.logErrorText.Size = new System.Drawing.Size(161, 13);
            this.logErrorText.TabIndex = 7;
            this.logErrorText.Text = "Неверный логин или пароль!";
            this.logErrorText.Visible = false;
            // 
            // logForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.logErrorText);
            this.Controls.Add(this.goRegButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logPassBox);
            this.Controls.Add(this.logLogBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "logForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.logForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logLogBox;
        private System.Windows.Forms.TextBox logPassBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button goRegButton;
        private System.Windows.Forms.Label logErrorText;
    }
}