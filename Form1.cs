using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            int nextX = random.Next(0, maxX);
            int nextY = random.Next(0, maxY);

            button1.Location = new Point(nextX, nextY);

            this.Text = $"Button Location - X: {nextX}, Y: {nextY}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
