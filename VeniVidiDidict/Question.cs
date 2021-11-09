using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeniVidiDidict
{
    public class Question
    {
        public Bitmap image { get; set; }
        public string question { get; }
        public string answer { get; }
        public string Topic { get; }

        public Question(Bitmap newImg, string newQuestion, string newAnswer, string newTopic)
        {
            this.image = newImg;
            this.question = newQuestion;
            this.answer = newAnswer;
            this.Topic = newTopic;
        }
    }
}
