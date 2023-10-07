using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public class TestModle : ObservableObject
    {
        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private bool showResultCollectionView;

        public bool ShowResultCollectionView
        {
            get => showResultCollectionView;
            set => SetProperty(ref showResultCollectionView, value);
        }
    }

    public partial class MainPage : ContentPage
    {

        public ObservableCollection<String> Users { get; set; }

        public TestModle User { get; set; }

        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Users = new ObservableCollection<string>();
            Users.Add("AAA");
            Users.Add("BBB");
            Users.Add("CCC");

            User = new TestModle();
            User.Name = "AAA";

            this.BindingContext = this;
        }

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {
            User.ShowResultCollectionView = !User.ShowResultCollectionView;
        }
    }
}
