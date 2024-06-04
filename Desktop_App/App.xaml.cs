using Desktop_App.MVVM.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Desktop_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// https://www.swiss-slackline.ch/en/what-is-slacklining/
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow();

            var knowledgeViewModel = new KnowledgeViewModel();
            var guideViewModel = new GuideViewModel();
            var linksViewModel = new LinksViewModel();

            var homeViewModel = new HomeViewModel(knowledgeViewModel,guideViewModel,linksViewModel);

            mainWindow.DataContext = homeViewModel;

            mainWindow.Show();
        }
    }

}
