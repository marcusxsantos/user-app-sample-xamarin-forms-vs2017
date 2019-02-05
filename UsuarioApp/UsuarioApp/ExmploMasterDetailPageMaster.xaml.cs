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

namespace UsuarioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExmploMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public ExmploMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new ExmploMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ExmploMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ExmploMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public ExmploMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ExmploMasterDetailPageMenuItem>(new[]
                {
                    new ExmploMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new ExmploMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new ExmploMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new ExmploMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new ExmploMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
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