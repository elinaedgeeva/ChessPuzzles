using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TeamProject_Elina_Julie.ViewModel;

namespace TeamProject_Elina_Julie
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow app = new MainWindow();
            MainMenuViewModel context = new MainMenuViewModel();
            app.DataContext = context;
            app.Show();
        }
        
       
        

    }
}
