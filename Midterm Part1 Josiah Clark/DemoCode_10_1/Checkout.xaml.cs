namespace DemoCode_10_1;

public partial class Checkout : ContentPage
{
	public Checkout()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Refresh();
    }
    async void EmptyCart()
    {
        CartClass.Names.Clear();
        CartClass.Quant.Clear();
        CartClass.Price.Clear();
        EndLabel.Text = "Thank you for your purchase!";
        Refresh();
        
        await Task.Delay(1000);
        EndLabel.Text = string.Empty;
    }
    void Refresh()
    {
        List<string> CartItems = new List<string>();
        double total = 0;
        for (int i = 0; i < CartClass.Names.Count; i++)
        {
            double linePrice = CartClass.Price[i] * CartClass.Quant[i];
            CartItems.Add($"{CartClass.Names[i]} x {CartClass.Quant[i]}");
            total += linePrice;
        }
        CartView.ItemsSource = CartItems;
        TotalLabel.Text = $"Total: ${total:F2}";
    }
    private void Button_Clicked(object sender, EventArgs e) //Will be replace with Checkout_Clicked at a later time for button formating.
    {
        EmptyCart();
    }
}