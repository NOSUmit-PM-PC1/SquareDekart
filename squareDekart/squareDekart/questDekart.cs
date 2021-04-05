using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareDekart
{
    public class Answer
    {
        string answer;
        int point;

        public Answer(string answer, int point)
        {
            this.answer = answer;
            this.point = point;
        }

        public int Point 
        { 
            get { return point; }
            set { if (value > 0 && value < 11) point = value; }
        }

        public string AnswerText
        {
            get { return answer; }
            set { if (!string.IsNullOrEmpty(value.Trim())) answer = value; }
        }

        public override string ToString()
        {
            return answer + ": " + point.ToString();
        }
    }
    public class QuestDekart
    {
        string title;
        List<Answer> answers = new List<Answer>();

        public QuestDekart(string title)
        {
            this.title = title;
        }

        public override string ToString()
        {
            string temp = "! " + title + "!\n";
            for (int i = 0; i < answers.Count(); i++)
                temp += "\t" + (i + 1) +". " + answers[i] + "\n";
            return temp;
        }

        public void Add(Answer ans)
        {
            answers.Add(ans);
        }

        public int SumPoint()
        {
            int sum = 0;
            foreach (var a in answers)
                sum += a.Point;
            return sum;
        }

        public List<string> GetListAnswers()
        {
            List<string> temp = new List<string>();
            foreach (var a in answers)
                temp.Add(a.ToString());
            return temp;
        }

        public Answer GetAnswer(int index)
        {
            return answers[index];
        }

        public string Title
        {
            get { return title; }
        }
    }
}
