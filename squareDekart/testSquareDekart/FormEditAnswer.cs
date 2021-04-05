using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using squareDekart;

namespace testSquareDekart
{
    public partial class FormEditAnswer : Form
    {
        Answer ans;

        public FormEditAnswer(Answer ans)
        {
            InitializeComponent();
            this.ans = ans;
            textBoxAnswer.Text = ans.AnswerText;
            textBoxPoint.Text = ans.Point.ToString();
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxAnswer.Text))
                    throw new Exception("Заполните ответ");
                ans.AnswerText = textBoxAnswer.Text;
                ans.Point = Convert.ToInt32(textBoxPoint.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
