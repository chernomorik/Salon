using BSalon.Models;
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

namespace BSalon.Views
{
    /// <summary>
    /// Логика взаимодействия для ServicesPage.xaml
    /// </summary>
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
        }
        public bool IsAdmin { get; private set; }

        public ObservableCollection<Service> Services { get; private set; }

        public ServicesPage(bool isAdmin)
        {
            IsAdmin = isAdmin;
            Services = new ObservableCollection<Service>(Session.Instance.Context.Services);
            InitializeComponent();
        }
    }
}
