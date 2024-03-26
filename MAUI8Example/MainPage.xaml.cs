using MAUI8Example.Data;

namespace MAUI8Example
{
    public partial class MainPage : ContentPage
    {
        MonkeyService monkeyService;
        public MainPage(MonkeyService monkeyService)
        {
            GC.Collect();
            InitializeComponent();

            this.monkeyService = monkeyService;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            monkeyService._monkeys.Clear();
        }

        private async void btnMonkeys_Clicked(object sender, EventArgs e)
        {
            GC.Collect();
            await Shell.Current.GoToAsync("monkeys");
        }
    }

}
