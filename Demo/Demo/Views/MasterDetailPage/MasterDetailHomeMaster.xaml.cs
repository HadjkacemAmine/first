using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views.MasterDetailPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailHomeMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailHomeMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailHomeMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailHomeMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailHomeMenuItem> MenuItems { get; set; }
            
            public MasterDetailHomeMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailHomeMenuItem>(new[]
                {
                    new MasterDetailHomeMenuItem { Id = 0, Title = "Utilisateurs" },
                    new MasterDetailHomeMenuItem { Id = 1, Title = "Adhésion" },
                    new MasterDetailHomeMenuItem { Id = 2, Title = "Dossier Technique" },
                    new MasterDetailHomeMenuItem { Id = 3, Title = "Certificat d'origine" },
                    
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}