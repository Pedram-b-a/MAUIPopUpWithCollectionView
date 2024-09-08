using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Sausage> sausages { get; set; }
        public MainPage()
        {
            InitializeComponent();

            sausages = new ObservableCollection<Sausage>();

            for (int i = 0; i < 20; i++)
            {
                sausages.Add(new Sausage("ShamSham", "/Resources/Images/almani.jpg", "NOT GOOD", 750000f));
            }

            BindingContext = this;
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            this.ShowPopupAsync(new PopUp());
        }
    }

}
