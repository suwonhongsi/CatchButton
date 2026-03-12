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
        const int MaxMiss = 50;

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

            if (missCount >= MaxMiss)
            {
                Target.Enabled = false;
                MessageBox.Show("Game Over! 20번이나 놓치셨군요.");
                this.Text = "Game Over - 다시 시작 버튼을 누르세요";
                return; 
            }

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

        private void Restrat_Click(object sender, EventArgs e)
        {
            score = 0;
            missCount = 0;

            Target.Enabled = true;
            Target.Size = new Size(216, 65);
            Target.Location = new Point(100, 100);

            this.Text = "게임을 다시 시작합니다!";
            MessageBox.Show("모든 정보가 초기화되었습니다. 다시 잡아보세요!");
        }
    }
    
}
