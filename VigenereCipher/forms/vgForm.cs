using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VigenereClass;

namespace VigenereCipher
{
    public partial class vgForm : Form
    {
        public vgForm()
        {
            InitializeComponent();
            beforeRichTextBox.Text = "Введите текст на английском языке...";
            beforeRichTextBox.ForeColor = Color.Gray;
            afterRichTextBox.Text = "Результат...";
            afterRichTextBox.ForeColor = Color.Gray;
            keyText.Text = "Введите ключ...";
            keyText.ForeColor = Color.Gray;
        }

        private void vgForm_Shown(object sender, EventArgs e)
        {
            logForm logForm = new logForm();
            logForm.ShowDialog();
        }

        private void code_Click(object sender, EventArgs e)
        {
            Vigenere vig = new Vigenere();
            char[] text = beforeRichTextBox.Text.ToCharArray();
            char[] key = keyText.Text.ToCharArray();
            text = vig.Code(key, text);
            afterRichTextBox.Text = String.Concat(text);
            afterRichTextBox.ForeColor = Color.Black;
        }

        private void decode_Click(object sender, EventArgs e)
        {
            Vigenere vig = new Vigenere();
            char[] text = beforeRichTextBox.Text.ToCharArray();
            char[] key = keyText.Text.ToCharArray();
            text = vig.Decode(key, text);
            afterRichTextBox.Text = String.Concat(text);
            afterRichTextBox.ForeColor = Color.Black;
        }

        private void beforeRichTextBox_Enter(object sender, EventArgs e)
        {
            if (beforeRichTextBox.Text == "Введите текст на английском языке...")
                beforeRichTextBox.Text = "";
            beforeRichTextBox.ForeColor = Color.Black;
        }

        private void beforeRichTextBox_Leave(object sender, EventArgs e)
        {
            if (beforeRichTextBox.Text == "")
            {
                beforeRichTextBox.Text = "Введите текст на английском языке...";
                beforeRichTextBox.ForeColor = Color.Gray;
            }
        }

        private void afterRichTextBox_Enter(object sender, EventArgs e)
        {
            if (afterRichTextBox.Text == "Результат...")
                afterRichTextBox.Text = "";
            afterRichTextBox.ForeColor = Color.Black;
        }

        private void afterRichTextBox_Leave(object sender, EventArgs e)
        {
            if (afterRichTextBox.Text == "")
            {
                afterRichTextBox.Text = "Результат...";
                afterRichTextBox.ForeColor = Color.Gray;
            }
        }

        private void keyText_Enter(object sender, EventArgs e)
        {
            if (keyText.Text == "Введите ключ...")
                keyText.Text = "";
            keyText.ForeColor = Color.Black;
        }

        private void keyText_Leave(object sender, EventArgs e)
        {
            if (keyText.Text == "")
            {
                keyText.Text = "Введите ключ...";
                keyText.ForeColor = Color.Gray;
            }
        }
    }
}
