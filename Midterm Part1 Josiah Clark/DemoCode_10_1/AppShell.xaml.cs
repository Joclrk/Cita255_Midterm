namespace DemoCode_10_1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ItemPage", typeof(ItemsPage));
        }
    }
}
