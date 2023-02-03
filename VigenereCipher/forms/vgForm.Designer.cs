namespace VigenereCipher
{
    partial class vgForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vgForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyText = new System.Windows.Forms.RichTextBox();
            this.afterRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decode = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.Button();
            this.beforeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.keyText);
            this.panel1.Controls.Add(this.afterRichTextBox);
            this.panel1.Controls.Add(this.decode);
            this.panel1.Controls.Add(this.code);
            this.panel1.Controls.Add(this.beforeRichTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 611);
            this.panel1.TabIndex = 0;
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(478, 289);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(110, 53);
            this.keyText.TabIndex = 5;
            this.keyText.Text = "";
            this.keyText.Enter += new System.EventHandler(this.keyText_Enter);
            this.keyText.Leave += new System.EventHandler(this.keyText_Leave);
            // 
            // afterRichTextBox
            // 
            this.afterRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.afterRichTextBox.Location = new System.Drawing.Point(594, 12);
            this.afterRichTextBox.MinimumSize = new System.Drawing.Size(460, 587);
            this.afterRichTextBox.Name = "afterRichTextBox";
            this.afterRichTextBox.ReadOnly = true;
            this.afterRichTextBox.Size = new System.Drawing.Size(460, 587);
            this.afterRichTextBox.TabIndex = 4;
            this.afterRichTextBox.Text = "";
            this.afterRichTextBox.Enter += new System.EventHandler(this.afterRichTextBox_Enter);
            this.afterRichTextBox.Leave += new System.EventHandler(this.afterRichTextBox_Leave);
            // 
            // decode
            // 
            this.decode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decode.Location = new System.Drawing.Point(478, 377);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(110, 23);
            this.decode.TabIndex = 3;
            this.decode.Text = "Расшифровать";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(478, 348);
            this.code.MaximumSize = new System.Drawing.Size(110, 23);
            this.code.MinimumSize = new System.Drawing.Size(110, 23);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(110, 23);
            this.code.TabIndex = 2;
            this.code.Text = "Зашифровать";
            this.code.UseVisualStyleBackColor = true;
            this.code.Click += new System.EventHandler(this.code_Click);
            // 
            // beforeRichTextBox
            // 
            this.beforeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beforeRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.beforeRichTextBox.MinimumSize = new System.Drawing.Size(460, 587);
            this.beforeRichTextBox.Name = "beforeRichTextBox";
            this.beforeRichTextBox.Size = new System.Drawing.Size(460, 587);
            this.beforeRichTextBox.TabIndex = 0;
            this.beforeRichTextBox.Text = "";
            this.beforeRichTextBox.Enter += new System.EventHandler(this.beforeRichTextBox_Enter);
            this.beforeRichTextBox.Leave += new System.EventHandler(this.beforeRichTextBox_Leave);
            // 
            // vgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 611);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1082, 650);
            this.MinimumSize = new System.Drawing.Size(1082, 650);
            this.Name = "vgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.vgForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.Button code;
        private System.Windows.Forms.RichTextBox beforeRichTextBox;
        private System.Windows.Forms.RichTextBox afterRichTextBox;
        private System.Windows.Forms.RichTextBox keyText;
    }
}

