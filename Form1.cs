using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        int score = 0;
        int missCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                return;
            }

            SystemSounds.Beep.Play();

            score -= 10;
            missCount++;

            int maxX = this.ClientSize.Width - Target.Width;
            int maxY = this.ClientSize.Height - Target.Height;

            int nextX = random.Next(0, maxX);
            int nextY = random.Next(0, maxY);

            Target.Location = new Point(nextX, nextY);

            this.Text = $"Button Location - X: {nextX}, Y: {nextY}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();

            score += 100;

            if (Target.Width > 20 && Target.Height > 20)
            {
                Target.Width = (int)(Target.Width * 0.9);
                Target.Height = (int)(Target.Height * 0.9);
            }

            MessageBox.Show("축하합니다! 버튼을 잡았어요!", "Success");
            this.Text = $"Score: {score} | Location - X: {Target.Location.X}, Y: {Target.Location.Y}";
        }
    }
    
}
