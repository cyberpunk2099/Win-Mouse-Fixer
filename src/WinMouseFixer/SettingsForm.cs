using System;
using System.Windows.Forms;

namespace WinMouseFixer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm() => InitializeComponent();

        private void DelayChanged(object sender, EventArgs e)
        {
            MouseInterceptor.Delay = TimeSpan.FromMilliseconds(delay.Value);
            delayDisplay.Text = $"<= {delay.Value} ms";
            Properties.Settings.Default.MouseButtonDelay = delay.Value;
            Properties.Settings.Default.Save();
        }

        private void RunningChanged(object sender, EventArgs e) => UpdateRunning();

        private void UpdateRunning()
        {
            if (running.Checked)
                MouseInterceptor.Start();
            else
                MouseInterceptor.Stop();
            Properties.Settings.Default.Running =
            runningMi.Checked                   =
            settingsPanel.Enabled               = running.Checked;
            Properties.Settings.Default.Save();
            Text = notifyIcon.Text =
                $"Win Mouse Fixer - {(running.Checked ? "RUNNING" : "STOPPED")}";
        }

        private void CloseClick(object sender, EventArgs e) => Close();

        private void DelayScroll(object sender, EventArgs e)
        {
            var value     = (double)delay.Value;
            var frequency = delay.TickFrequency;
            delay.Value   = (int)Math.Round(value / frequency) * frequency;
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            running.Checked    = Properties.Settings.Default.Running;
            runningMi.Checked  = Properties.Settings.Default.Running;
            delay.Value        = Properties.Settings.Default.MouseButtonDelay;
            delayDisplay.Text  = $"<= {delay.Value} ms";
            mouseLeft.Checked  = Properties.Settings.Default.LeftButton;
            mouseRight.Checked = !mouseLeft.Checked;
            MouseInterceptor.TrackLeftButton = mouseLeft.Checked;
            MouseInterceptor.Delay = TimeSpan.FromMilliseconds(delay.Value);
            if (running.Checked) MouseInterceptor.Start();
            MouseInterceptor.Fixed =
                i => indicator.Text = $"{i} fixed"; 
        }

        private void MouseButtonChanged(object sender, EventArgs e)
        {
            MouseInterceptor.TrackLeftButton = mouseLeft.Checked;
            Properties.Settings.Default.LeftButton = mouseLeft.Checked;
            Properties.Settings.Default.Save();
        }

        private void ChkMouseDown(object sender, MouseEventArgs e)
            => (sender as RadioButton).Checked = true;

        private void SettingsFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = true;
            Hide();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void SettingsClick(object sender, EventArgs e)
        {
            Show();
            BringToFront();
        }

        private void FixCheckedChanged(object sender, EventArgs e)
            => running.Checked = runningMi.Checked;

        private void SettingsFormClosed(object sender, FormClosedEventArgs e)
        {
            MouseInterceptor.Fixed = null;
            MouseInterceptor.Stop();
        }

        private void AboutClick(object sender, EventArgs e)
        {
            using (var about = new AboutBox())
                about.ShowDialog();
        }
    }
}
