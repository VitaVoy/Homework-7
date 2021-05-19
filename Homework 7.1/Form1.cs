using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_7._1
{
    public partial class Form1 : Form
    {
        Random r;
        int n;
        Stack<string> history = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblCount.Text = "0";
            this.Text = "Удвоитель";
            r = new Random();
            
        }

        int count = 0;

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            var t = int.Parse(lblNumber.Text);
            history.Push(t.ToString());
            if (t != n)
            {
                t += 1;
                lblNumber.Text = t.ToString();
                count++;
                lblCount.Text = Convert.ToString(count);
            }
            if (t == n) MessageBox.Show($"Ура!");
           
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            var t = int.Parse(lblNumber.Text);
            history.Push(t.ToString());
            if (t != n)
            {
                t *= 2;
                lblNumber.Text = t.ToString();
                count++;
                lblCount.Text = Convert.ToString(count);
            }
            if (t == n) MessageBox.Show($"Ура!");
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            count = 0;
            lblCount.Text = Convert.ToString(count);

        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = r.Next(20, 30);

            MessageBox.Show($"Угадай число {n}");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show($"Программа создана 18.05.2021");
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            lblNumber.Text = history.Pop();
        }
    }
}
