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
                new { Text = "1340 The Fan 3", Value = "1340" }
            };

            comboBox1.DataSource = items;

            //Default to 680 and start playing on startup.
            webBrowser1.Navigate("http://player.tritondigital.com/15081");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() == "680")
                webBrowser1.Navigate("http://player.tritondigital.com/15081");
            else
                webBrowser1.Navigate("http://player.tritondigital.com/19601");
        }
    }
}
