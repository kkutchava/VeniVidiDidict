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
            Question question = new Question(Properties.Resources.testImage, "1", "Calculus");
            qustionView = new QuestionView(question);
            qustionView.Show();
        }

        private void Fight(object sender, EventArgs e)
        {

        }

        private void Info(object sender, EventArgs e)
        {

        }
    }
}
