using RamazanApp.Models;

namespace RamazanApp.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage(string cityName,string date, List<Times> playerTimes)
	{
		InitializeComponent();
        LabelcityName.Text = cityName;
        labelDate.Text = date;
        BindingContext = playerTimes;
        this.BindingContext = playerTimes.FirstOrDefault();
    }
}