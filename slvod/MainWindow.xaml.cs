using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.Windows;

namespace slvod
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Properties.Settings.Default.PlayerPath != string.Empty)
            {
                lblPlayerPath.Content = Properties.Settings.Default.PlayerPath;
            }
            else
            {
                lblPlayerPath.Content = "Player path not specified!";
            }
            txtboxVodURL.Text = Properties.Settings.Default.PreviousVOD;
        }

        private void btnChangePlayerPath_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                lblPlayerPath.Content = dialog.FileName;
                Properties.Settings.Default.PlayerPath = dialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void btnStartVod_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtboxVodURL.Text) & Uri.IsWellFormedUriString(txtboxVodURL.Text, UriKind.Absolute) & txtboxVodURL.Text.Contains("twitch.tv"))
            {
                // Save our VOD URL
                Properties.Settings.Default.PreviousVOD = txtboxVodURL.Text;
                Properties.Settings.Default.Save();

                // Start our player
                Process player = new Process();
                player.StartInfo.CreateNoWindow = true;
                player.StartInfo.UseShellExecute = false;
                player.StartInfo.FileName = "streamlink.exe";
                player.StartInfo.Arguments = $@"{txtboxVodURL.Text} best --player-passthrough hls --player ""{Properties.Settings.Default.PlayerPath}""";
                player.Start();
            }
            else
            {
                MessageBox.Show("You must specify a Twitch VOD URL");
            }
        }
    }
}