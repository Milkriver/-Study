using System;
using System.IO;
using System.Windows.Forms;

namespace ReaderForFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            string userAnswer = textBox1.Text;

            if (userAnswer.Contains('.'))
            {
                if (!userAnswer.Contains(".txt"))
                {
                    richTextBox1.Text = "Неверный формат файла";
                    return;
                }
            }
            else
            {
                userAnswer += ".txt";
            }

            var directory = Environment.CurrentDirectory;
            var filePath = Path.Combine(directory, userAnswer);

            if (!File.Exists(filePath))
            {
                richTextBox1.Text = "Файла нет";
                return;
            }

            richTextBox1.Text = File.ReadAllText(filePath);
        }
    }
}
