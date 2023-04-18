using CommunityToolkit.Maui.Views;
using Newtonsoft.Json;
using RamazanApp.Models;
using RamazanApp.Services;
using System.Collections.ObjectModel;

namespace RamazanApp.Views;

public partial class HomePage : ContentPage
{
    private readonly ApiService _apiService = new ApiService();
     
    public HomePage( )
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var cities = await _apiService.GetCitiesAsync();
        myPicker.ItemsSource = cities;
        var dates = await _apiService.GetDatesAsync();
        myDatePicker.ItemsSource = dates; 
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Cities cities = myPicker.SelectedItem as Cities;
        Dates dates = myDatePicker.SelectedItem as Dates;

        if (cities != null && dates!=null)
        {
            var playerTimes = await _apiService.GetTimesAsync(cities.Id,dates.Id);
            await Navigation.PushAsync(new DetailPage(cities.CityName,dates.Date,playerTimes));
        }
        else
        {
            await DisplayAlert("Uyarý", "Lütfen il ve tarih seçiniz", "Tamam");
        }
    }
    
}