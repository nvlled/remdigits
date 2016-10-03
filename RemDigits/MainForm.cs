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
        const int INTERVAL = 2100;
        const string TEXT_START = "start";
        const string TEXT_STOP = "stop";
        const string TEXT_ENTER = "enter";

        Timer timer;
        string digits = "";
        int index = 0;

        public MainForm()
        {
            InitializeComponent();
            timer = new Timer();
            numSpeed.Value = (int) INTERVAL;
            timer.Tick += timer_Tick;
            btnStart.Text = TEXT_START;
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
                btnStart.Text = TEXT_ENTER;
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
            if (btnStart.Text == TEXT_START)
            {
                digits = genRandomDigits((int)numLength.Value);
                timer.Stop();
                index = 0;
                remNum.ReadOnly = true;
                btnStart.Text = TEXT_STOP;
                remNum.Text = "Ready!";
                tsProgress.Maximum = digits.Length;

                delay(200, () =>
                {
                    timer.Interval = (int) numSpeed.Value;
                    timer.Start();
                });
            }
            else if (btnStart.Text == TEXT_STOP)
            {
                timer.Stop();
                remNum.Text = "";
                digits = "";
                index = 0;
                btnStart.Text = TEXT_START;
            }
            else
            {
                btnStart.Text = TEXT_START;
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
