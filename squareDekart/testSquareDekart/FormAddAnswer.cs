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
    public partial class FormAddAnswer : Form
    {
        QuestDekart dec;

        public FormAddAnswer(QuestDekart dec)
        {
            InitializeComponent();
            this.dec = dec;
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxAnswer.Text))
                    throw new Exception("Заполните ответ");
                Answer a = new Answer(textBoxAnswer.Text,
                                Convert.ToInt32(textBoxPoint.Text));
                dec.Add(a);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
