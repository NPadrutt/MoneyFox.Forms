namespace MoneyFox.Forms.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new MoneyFox.Forms.App());
        }
    }
}