using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
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
                    new MasterDetailHomeMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailHomeMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailHomeMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailHomeMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailHomeMenuItem { Id = 4, Title = "Page 5" },
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