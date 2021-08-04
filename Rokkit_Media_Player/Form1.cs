using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Rokkit_Media_Player
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelNavigation.Top = TracksButton.Top;
            PanelNavigation.Left = TracksButton.Left;
            TracksButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nwidthEllipse,
                int nHeightEllipse
            );

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TracksButton_Click(object sender, EventArgs e)
        {
            PanelNavigation.Top = TracksButton.Top;
            PanelNavigation.Left = TracksButton.Left;
            TracksButton.BackColor = Color.FromArgb(46, 51, 73);

            List<string> listMP3files = Directory.GetFiles($@"D:\music").ToList();

            GroupDocs.Metadata
        }

        private void ArtistsButton_Click(object sender, EventArgs e)
        {
            PanelNavigation.Top = ArtistsButton.Top;
            PanelNavigation.Left = ArtistsButton.Left;
            TracksButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void AlbumButton_Click(object sender, EventArgs e)
        {
            PanelNavigation.Top = AlbumButton.Top;
            PanelNavigation.Left = AlbumButton.Left;
            TracksButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            PanelNavigation.Top = SettingsButton.Top;
            PanelNavigation.Left = SettingsButton.Left;
            TracksButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void TracksButton_Leave(object sender, EventArgs e)
        {
            TracksButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ArtistsButton_Leave(object sender, EventArgs e)
        {
            ArtistsButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void AlbumButton_Leave(object sender, EventArgs e)
        {
            AlbumButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void SettingsButton_Leave(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void DraggablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }
    }
}
