namespace MauiAppDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
        }
    }

}
