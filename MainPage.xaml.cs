namespace TestPlaceholderProblem
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            // Bind the ViewModel
            BindingContext = vm;
        }
    }

}
