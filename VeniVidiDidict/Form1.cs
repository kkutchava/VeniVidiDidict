using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeniVidiDidict
{
    public partial class Form1 : Form
    {
        private QuestionView qustionView;
        public Form1()
        {
            InitializeComponent();
        }

        private void Castle_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                Question question = getQuestion(btn.Name.ToString());
                qustionView = new QuestionView(question);
                qustionView.Show();
            }
        }

        private void Fight(object sender, EventArgs e)
        {

        }

        private void Info(object sender, EventArgs e)
        {

        }

        private Question getQuestion(string questionName)
        {
            string name = questionName.Replace("CastleButton", string.Empty);
            Question question;
            switch (name) {
                case "1_1":
                    question = new Question(Properties.Resources.question1_1, "Evaluate the Limit", "1", "The Limit of a Function");
                    break;
                case "1_2":
                    question = new Question(Properties.Resources.question1_2, "Evaluate the Limit", "1", "The Limit of a Function");
                    break;
                case "1_3":
                    question = new Question(Properties.Resources.question1_3, "Find the vertical asymptote of the function", "1", "The Limit of a Function");
                    break;
                case "2_1":
                    question = new Question(Properties.Resources.question2_1, "Evaluate Derivative of the function", "1", "Differentiation Rules");
                    break;
                case "2_2":
                    question = new Question(Properties.Resources.question2_2, "Evaluate the first and the second\nderivatives of the function. ", "1", "Differentiation Rules");
                    break;
                default:
                    question = new Question(Properties.Resources.testImage, "none", "1", "Calculus");
                    break;
            }
            return question;
        }

        private void genClick(object sender, EventArgs e)
        {
            GenInfo g = new GenInfo();
            g.Show();
        }
    }
}
