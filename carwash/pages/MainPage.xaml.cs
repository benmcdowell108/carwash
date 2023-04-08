namespace carwash;
/*
 Program Author: Amber McDowell

Assignment: Lenny's Car Wash

Description: 

This program uses a gui to simulate a web page where one would order a car wash service.

 */
public partial class MainPage : ContentPage
{
	int wash = 0;
    double totalCost = 0.0;

	public MainPage()
	{
		InitializeComponent();
        layoutReceiptScreen.IsVisible = false;
        error.IsVisible = false;
        airfresh.IsVisible = false;
        wheel.IsVisible = false;
        wax.IsVisible = false;
        vacuum.IsVisible = false;

    }
    private void washType(object sender, EventArgs e)
    {
        RadioButton selected = (sender as RadioButton);
        if (selected.Content.ToString() == "Basic Wash ($10.00)")
        {
            wash = 1;
            washReceipt.Text = $"Wash Selected: {selected.Content}";
            totalCost += 10;
        }
        else if (selected.Content.ToString() == "Premium Wash ($15.00)")
        {
            wash = 2;
            washReceipt.Text = $"Wash Selected: {selected.Content}";
            totalCost += 15;
        }
        else if (selected.Content.ToString() == "Ultra Wash ($20.00)")
        {
            wash = 3;
            washReceipt.Text = $"Wash Selected: {selected.Content}";
            totalCost += 20;
        }
    }
    private void newOrder(object sender, EventArgs e)
    {
        chkAirFresh.IsChecked = false;
        chkWax.IsChecked = false;
        chkWheelShine.IsChecked = false;
        chkVacuum.IsChecked = false;
        Basic.IsChecked = false;
        Premium.IsChecked = false;
        Ultra.IsChecked = false;
        

        layoutSelectionScreen.IsVisible = true;
        layoutReceiptScreen.IsVisible = false;
        totalCost = 0;
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
        if (wash == 0) 
        {
            error.IsVisible = true;

        }
        else
        {
            if (chkAirFresh.IsChecked == true)
            {
                totalCost += 2;
                airfresh.IsVisible = true;
                
            }
            if (chkWax.IsChecked == true)
            {
                totalCost += 5;
                wax.IsVisible = true;

            }
            if (chkWheelShine.IsChecked == true)
            {
                totalCost += 5;
                wheel.IsVisible = true;

            }
            if (chkVacuum.IsChecked == true)
            {
                totalCost += 2;
                vacuum.IsVisible = true;

            }
            total.Text = $"Total Cost: ${totalCost}.00";
            layoutSelectionScreen.IsVisible = false;
            layoutReceiptScreen.IsVisible = true;

        }
    }
}

