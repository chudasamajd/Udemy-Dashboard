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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace Udemy_Dashboard
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(1,10),
                        new ObservablePoint(2,18),
                        new ObservablePoint(3,8),
                        new ObservablePoint(4,23),
                        new ObservablePoint(5,27),
                        new ObservablePoint(6,19),
                        new ObservablePoint(7,25),
                    },
                    PointGeometrySize = 15
                }
            };
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
        }

        private void btnMyvideos_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMyvideos.Height;
            pnlNav.Top = btnMyvideos.Top;
            pnlNav.Left = btnMyvideos.Left;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReports.Height;
            pnlNav.Top = btnReports.Top;
            pnlNav.Left = btnReports.Left;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
        }
    }
}
