using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace magic_8_ball
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<Tuple<string, string>> categorizedAnswers = new List<Tuple<string, string>>();

        public Form1()
        {
            InitializeComponent();

            categorizedAnswers.Add(new Tuple<string, string>("It is certain.", "Positive"));
            categorizedAnswers.Add(new Tuple<string, string>("It is decidedly so.", "Positive"));
            categorizedAnswers.Add(new Tuple<string, string>("Without a doubt.", "Positive"));
            categorizedAnswers.Add(new Tuple<string, string>("Yes definitely.", "Positive"));
            categorizedAnswers.Add(new Tuple<string, string>("You may rely on it.", "Positive"));

            categorizedAnswers.Add(new Tuple<string, string>("As I see it, yes.", "Positive"));
            categorizedAnswers.Add(new Tuple<string, string>("Most likely.", "Positive"));
            categorizedAnswers.Add(new Tuple<string, string>("Outlook good.", "Positive"));
            categorizedAnswers.Add(new Tuple<string, string>("Yes.", "Positive"));
            categorizedAnswers.Add(new Tuple<string, string>("Signs point to yes.", "Positive"));

            categorizedAnswers.Add(new Tuple<string, string>("Reply hazy, try again.", "Neutral"));
            categorizedAnswers.Add(new Tuple<string, string>("Ask again later.", "Neutral"));
            categorizedAnswers.Add(new Tuple<string, string>("Better not tell you now.", "Neutral"));
            categorizedAnswers.Add(new Tuple<string, string>("Cannot predict now.", "Neutral"));
            categorizedAnswers.Add(new Tuple<string, string>("Concentrate and ask again.", "Neutral"));

            categorizedAnswers.Add(new Tuple<string, string>("Don't count on it.", "Negative"));
            categorizedAnswers.Add(new Tuple<string, string>("My reply is no.", "Negative"));
            categorizedAnswers.Add(new Tuple<string, string>("My sources say no.", "Negative"));
            categorizedAnswers.Add(new Tuple<string, string>("Outlook not so good.", "Negative"));
            categorizedAnswers.Add(new Tuple<string, string>("Very doubtful.", "Negative"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = random.Next(categorizedAnswers.Count);
            string response = categorizedAnswers[index].Item1;
            string category = categorizedAnswers[index].Item2;

            label1.Text = response;


            label3.Text = "Response: " + category;
        }


    }
}
