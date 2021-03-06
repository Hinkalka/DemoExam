using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LanguageSchool.Pages
{
    /// <summary>
    /// Логика взаимодействия для LatestAppointments.xaml
    /// </summary>
    public partial class LatestAppointments : Page
    {
        public LatestAppointments()
        {
            InitializeComponent();
            dataGridCloseService.ItemsSource = DbConnection.SchoolBase.ClientService.ToList().OrderByDescending(x => x.startDate);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(30);
            timer.Tick += timer_Tick;
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            dataGridCloseService.Items.Refresh();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.MainFrame.GoBack();
        }
    }
}
