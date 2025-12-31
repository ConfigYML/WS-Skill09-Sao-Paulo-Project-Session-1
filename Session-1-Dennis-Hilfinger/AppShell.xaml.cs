namespace Session_1_Dennis_Hilfinger
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SponsorRunnerPage), typeof(SponsorRunnerPage));
            Routing.RegisterRoute(nameof(SponsorshipConfirmationPage), typeof(SponsorshipConfirmationPage));
            Routing.RegisterRoute(nameof(FindOutMorePage), typeof(FindOutMorePage));
            Routing.RegisterRoute(nameof(CharityListPage), typeof(CharityListPage));
        }
    }
}
