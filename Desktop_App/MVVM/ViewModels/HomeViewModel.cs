using Desktop_App.Core;
using System.Windows.Input;

namespace Desktop_App.MVVM.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        private ViewModelBase _displayView;
        public ViewModelBase displayView
        {
            get { return _displayView; }
            set { _displayView = value; OnPropertyChanged(); }
        }

        public ViewModelBase knowledgeViewModel { get; set; }
        public ViewModelBase guideViewModel { get; set; }
        public ViewModelBase linksViewModel { get; set; }

        public ICommand knowledgeViewSelect { get; set; }
        public ICommand guideViewSelect { get; set; }
        public ICommand linksViewSelect { get; set; }

        
        

        public HomeViewModel(ViewModelBase knowledgeViewModel, ViewModelBase guideViewModel, ViewModelBase linksViewModel)
        {
            this.knowledgeViewModel = knowledgeViewModel;
            this.guideViewModel = guideViewModel;
            this.linksViewModel = linksViewModel;

            knowledgeViewSelect = new RelayCommand(KnowledgeView);
            guideViewSelect = new RelayCommand(GuideView);
            linksViewSelect = new RelayCommand(LinksView);

           
                
        }

        private void KnowledgeView(object obj)
        {
            displayView = this.knowledgeViewModel;
        }

        private void GuideView(object obj)
        {
            displayView = this.guideViewModel;
        }

        private void LinksView(object obj)
        {
            displayView = this.linksViewModel;
        }
    }
}
