using System.Diagnostics;
using System.Windows.Forms;

namespace WinMouseFixer
{
    public partial class AboutBox : Form
    {
        public AboutBox() => InitializeComponent();

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start((sender as LinkLabel).Text);
    }
}
