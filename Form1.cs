using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();

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
            MessageBox.Show("축하합니다! 버튼을 잡았어요!", "Success");
        }
    }
}
