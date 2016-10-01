using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemDigits
{
    public partial class MainForm : Form
    {
        Timer timer;
        string digits = "";
        int index = 0;

        public MainForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (index < digits.Length)
            {
                remNum.Text = "";
                System.Threading.Thread.Sleep(500);
                delay(300, () =>
                {
                    if (index < digits.Length)
                        remNum.Text = digits[index].ToString();
                    index++;
                    tsProgress.Value = index;
                });
            }
            else if (digits.Length > 0)
            {
                btnStart.Text = "Enter";
                remNum.Text = "";
                remNum.ReadOnly = false;
                timer.Stop();
            }
        }

        string genRandomDigits(int len)
        {
            var digits = "";
            var r = new Random();
            while (digits.Length != len)
            {
                var n = r.Next() % len;
                digits += n.ToString();
            }
            return digits;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            doHandler();
        }

        void doHandler()
        {
            if (btnStart.Text == "Start")
            {
                digits = genRandomDigits((int)numLength.Value);
                timer.Stop();
                index = 0;
                remNum.ReadOnly = true;
                btnStart.Text = "Stop";
                remNum.Text = "Ready!";
                tsProgress.Maximum = digits.Length;

                delay(200, () =>
                {
                    timer.Start();
                });
            }
            else if (btnStart.Text == "Stop")
            {
                timer.Stop();
                remNum.Text = "";
                digits = "";
                index = 0;
                btnStart.Text = "Start";
            }
            else
            {
                btnStart.Text = "Start";
                remNum.ReadOnly = true;

                if (remNum.Text == digits)
                {
                    remNum.Text = "✓" + digits;
                }
                else
                {
                    remNum.Text = "✘ " + digits;
                }
            }
        }

        void delay(int millis, Action action)
        {
            var t = new Timer();
            t.Interval = millis;
            t.Start();
            t.Tick += (s, e) =>
            {
                t.Stop();
                action();
            };
        }

        private void remNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                doHandler();
        }
    }
}
