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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Schiefer_Wurf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer time = new DispatcherTimer();
        double dt = 1.0 / 60.0;


        public MainWindow()
        {
            InitializeComponent();
            time.Interval = TimeSpan.FromSeconds(dt);
            time.Tick += Time_Tick;
        }
        double V0, Winkel;
        const double G = 981;

        private void Time_Tick(object sender, EventArgs e)
        {
            double x = Canvas.GetLeft(el);
            double y = Canvas.GetBottom(el);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            time.Start();
        }

        private void Startwert()
        {
            V0 = 
        }
    }
}
