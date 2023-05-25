using BLL.Festivals;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FestivalGUICore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FestivalBLL bll = new FestivalBLL();
        private ObservableCollection<Festival> _festivals;
        private ObservableCollection<Artist> _artists;

        public MainWindow()
        {
            InitializeComponent();

            //bll.AddArtistToFestival(bll.GetArtist(-1), bll.GetFestival(-3));
            //bll.AddArtistToFestival(bll.GetArtist(-2), bll.GetFestival(-1));
            //bll.AddArtistToFestival(bll.GetArtist(-3), bll.GetFestival(-1));

            _festivals = bll.GetFestivalList();
            festivalList.ItemsSource = _festivals;
            festivalGrid.DataContext = _festivals;
            _artists = bll.GetArtistList();
            artistList.ItemsSource = _artists;
            artistGrid.DataContext = _artists;


            
            
        }

        private void festivalList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Festival festival = bll.GetFestival(((sender as ListView).SelectedItem as Festival).FestivalID);
            festivalArtists.ItemsSource = bll.GetFestivalArtists(festival);
        }

        private void ArtistRet_Click(object sender, RoutedEventArgs e)
        {
            Artist tempArtist = bll.GetArtist((artistList.SelectedItem as Artist).ArtistID);
            tempArtist.Name = ArtistName.Text;
            tempArtist.Salary = Int32.Parse(ArtistSalary.Text);
            bll.EditArtist(tempArtist);
        }

        private void ArtistDelete_Click(object sender, RoutedEventArgs e)
        {
            bll.DeleteArtist(bll.GetArtist((artistList.SelectedItem as Artist).ArtistID));
        }
    }
}
