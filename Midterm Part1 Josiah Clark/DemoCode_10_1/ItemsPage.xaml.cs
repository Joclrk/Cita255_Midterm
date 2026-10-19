namespace DemoCode_10_1;

[QueryProperty(nameof(Index), "index")]

public partial class ItemsPage : ContentPage
{
    int detailindex;
	public ItemsPage()
	{
		InitializeComponent();
	}

	public string Index
    {
        set
        {
            detailindex = int.Parse(value);
            ProductLabel.Text = Items.Names[detailindex];
            PriceLabel.Text = $"${Items.Price[detailindex]:F2}";
            DescriptionLabel.Text = Items.Description[detailindex];
            string[] ProductImages = {"plainbagel.jpg", "cheesebagel.jpg", "pizzabagels.jpg","moldybagel.jpg" };
            productImage.Source = ProductImages[detailindex];

            if (detailindex == 3)
            { 
                QtyEntry.IsVisible = false;
                AddToCartButton.IsVisible = false;
                InStockLabel.IsVisible = false;
                QtyLabel.IsVisible = false;
                OutOfStockLabel.IsVisible = true;
            }
            else
            {
                QtyEntry.IsVisible = true;
                AddToCartButton.IsVisible = true;
                InStockLabel.IsVisible = true;
                QtyLabel.IsVisible = true;
                OutOfStockLabel.IsVisible = false;
            }
        }
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(QtyEntry.Text, out int UserEntry) && UserEntry > 0 && UserEntry <= 99)
        {
            QtyEntry.Placeholder = $"Added {UserEntry} {Items.Names[detailindex]} to cart";
            QtyEntry.Text = string.Empty;
            CartClass.Quant.Add(UserEntry);
            CartClass.Names.Add(Items.Names[detailindex]);
            CartClass.Price.Add(Items.Price[detailindex]);
        }
        else
        {
            QtyEntry.Placeholder = "Error: Please enter a valid number";
            QtyEntry.Text = string.Empty;
        }
    }
}