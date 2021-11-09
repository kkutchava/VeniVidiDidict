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
        public string answer { get; }
        public string Topic { get; }

        public Question(Bitmap newImg, string newAnswer, string newTopic)
        {
            this.image = newImg;
            this.answer = newAnswer;
            this.Topic = newTopic;
        }
    }
}
