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
    public partial class QuestionView : Form
    {
        private Question question;
        public QuestionView(Question newQuestion)
        {
            InitializeComponent();
            this.question = newQuestion;
            this.imageBox.Image = question.image;
            this.topicNameLbl.Text = question.Topic;

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(question.answer == answerBox.Text)
            {
                ResultLbl.Text = "Good Job!";
                ResultLbl.ForeColor = Color.Green;

            } else
            {
                ResultLbl.Text = "ahh not right, try to learn more";
                ResultLbl.ForeColor = Color.Blue;
            }
        }

        private void answerBox_Enter(object sender, EventArgs e)
        {
            if (answerBox.Text == "Enter answer here...")
            {
                answerBox.Text = "";
                answerBox.ForeColor = Color.Black;
            }
        }
    }
}
