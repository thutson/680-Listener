using System;
using System.Windows.Forms;

namespace _680Listener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            var items = new[] {
                new { Text = "680 The Fan", Value = "680" },
                new { Text = "1230 The Fan 2", Value = "1230" },
                new { Text = "1340 The Fan 3", Value = "1340" },
                new { Text = "Southern Sports Today", Value = "SST" },
                new { Text = "750 WSB AM", Value = "750" }
            };

            comboBox1.DataSource = items;

            webBrowser1.ScriptErrorsSuppressed = true;
            //Default to 680 and start playing on startup.
            webBrowser1.Navigate(@"http://player.listenlive.co/59261");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() == "680")
                webBrowser1.Navigate(@"https://player.listenlive.co/59261");
            else if (comboBox1.SelectedValue.ToString() == "1230")
                webBrowser1.Navigate(@"https://player.listenlive.co/59271");
            else if (comboBox1.SelectedValue.ToString() == "1340")
                webBrowser1.Navigate(@"https://player.listenlive.co/59281");
            else if (comboBox1.SelectedValue.ToString() == "SST")
                webBrowser1.Navigate("https://player.listenlive.co/57991/");
            else
                webBrowser1.Navigate("https://player.streamguys.com/cmg/atl750/sgplayer/player.php");
        }
    }
}
