using System;
using System.Windows.Forms;
using squareDekart;



namespace testSquareDekart
{
    public partial class FormMain : Form
    {
        QuestDekart dec;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Answer a = new Answer("Чяго", 2);
            Answer b = new Answer("НиЧяго", 5);
            dec = new QuestDekart("Что будет если это произойдет");
            dec.Add(a);
            dec.Add(b);
            listBoxAnswersI.DataSource = dec.GetListAnswers();
            labelTitleI.Text = dec.Title  + " " + dec.SumPoint();
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            FormAddAnswer form = new FormAddAnswer(dec);
            form.ShowDialog();
            listBoxAnswersI.DataSource = dec.GetListAnswers();
        }

        private void buttonEditAnswer_Click(object sender, EventArgs e)
        {
            int index = listBoxAnswersI.SelectedIndex;
            FormEditAnswer form = new FormEditAnswer(dec.GetAnswer(index));
            form.ShowDialog();
            listBoxAnswersI.DataSource = dec.GetListAnswers();
           
        }
    }
}
