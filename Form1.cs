using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeTimer
{
    public partial class MainWindow : Form
    {
        int errors = 0;
        bool textSet = false;
        bool inWork = false;
        Stopwatch sw = new Stopwatch();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void typingField_TextChanged(object sender, EventArgs e)
        {
            if (textSet)
            {
                if (!inWork && setText.Text.StartsWith(typingField.Text) && (typingField.Text != ""))
                {
                    inWork = true;
                    timer1.Enabled = true;
                    timer1.Start();
                    sw.Start();
                    titleLabel.Text = "Let's type!";
                    setButton.Enabled = false;
                }
                else if (inWork)
                {
                    if (!setText.Text.StartsWith(typingField.Text))
                    {
                        errors++;
                        typingField.Text = typingField.Text.Remove(typingField.Text.Length - 1);
                        typingField.SelectionStart = typingField.Text.Length;
                        Shake(MainWindow.ActiveForm);
                    }
                    if (setText.Text == typingField.Text)
                    {
                        sw.Stop();
                        timer1.Stop();
                        inWork = false;
                        setButton.Enabled = true;
                        titleLabel.Text = "Congrats! You have " + errors + " errors!";
                    }
                }
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            sw.Reset();
            timeLabel.Text = "00:00.000";
            setText.Text = typingField.Text;
            typingField.Text = "";
            textSet = true;
            titleLabel.Text = "Ready to go!";
            errors = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;
            timeLabel.Text = String.Format("{0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        private void typingField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!inWork)
                    setButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        private static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 2;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
    }
}
