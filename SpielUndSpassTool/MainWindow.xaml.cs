using SpielUndSpassTool;
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

namespace SpielUndSpassTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControlHome();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCreate":
                    usc = new UserControlCreateArticle();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            SpielUndSpassTool.SpielUndSpassDatenbankDataSet spielUndSpassDatenbankDataSet = ((SpielUndSpassTool.SpielUndSpassDatenbankDataSet)(this.FindResource("spielUndSpassDatenbankDataSet")));
            // Load data into the table Auftraege. You can modify this code as needed.
            SpielUndSpassTool.SpielUndSpassDatenbankDataSetTableAdapters.AuftraegeTableAdapter spielUndSpassDatenbankDataSetAuftraegeTableAdapter = new SpielUndSpassTool.SpielUndSpassDatenbankDataSetTableAdapters.AuftraegeTableAdapter();
            spielUndSpassDatenbankDataSetAuftraegeTableAdapter.Fill(spielUndSpassDatenbankDataSet.Auftraege);
            System.Windows.Data.CollectionViewSource auftraegeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("auftraegeViewSource")));
            auftraegeViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
