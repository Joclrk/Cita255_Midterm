namespace DemoCode_10_1;

public partial class RottenBagel : ContentPage
{
	public RottenBagel()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            int UserEntry = int.Parse(QtyEntry.Text);
            QtyEntry.Placeholder = "In Cart!";
            QtyEntry.Text = string.Empty;
        }
        catch (ArgumentNullException)
        {
            QtyEntry.Placeholder = "Error:Input Empty";
            QtyEntry.Text = string.Empty;
        }
        catch (FormatException)
        {
            QtyEntry.Placeholder = "Error: No Letters or Similar in this Field";
            QtyEntry.Text = string.Empty;
        }
        catch
        {
            QtyEntry.Placeholder = "Error: Unkown Error Found";
            QtyEntry.Text = string.Empty;
        }
    }
}