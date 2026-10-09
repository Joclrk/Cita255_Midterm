using Microsoft.Extensions.DependencyInjection;

namespace DemoCode_10_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("PlainBagel", typeof(PlainBagel));
            Routing.RegisterRoute("CheeseBagel", typeof(CheeseBagel));
            Routing.RegisterRoute("PizzaBagel", typeof(PizzaBagel));
            Routing.RegisterRoute("RottenBagel", typeof(RottenBagel));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}