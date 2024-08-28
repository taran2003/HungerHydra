namespace HungerHydra
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            if (Current != null) Current.UserAppTheme = AppTheme.Light;
        }
    }
}
