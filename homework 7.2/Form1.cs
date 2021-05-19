using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_7._2
{
    public partial class guessNumber : Form
    {
        Random r;
        int n;
        public guessNumber()
        {
            InitializeComponent();
            button1.Text = "Проверить";
            r = new Random();
            n = r.Next(1, 100);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {                       
            int t = Convert.ToInt32(textBox1.Text);

            if (n < t)
            {
                MessageBox.Show($"Перебор");
                textBox1.Clear();
            }
            else if (n > t)
            {
                MessageBox.Show($"Недобор");
                textBox1.Clear();
            }
            else
                MessageBox.Show($"Ура! Вы победили");
                
                
        }
    }
    
}
