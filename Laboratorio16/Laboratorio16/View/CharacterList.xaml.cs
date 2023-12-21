using Laboratorio16.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio16.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterList : ContentPage
    {
        private RickAndMortyApiService _apiService;
        public CharacterList()
        {
            InitializeComponent();
            _apiService = new RickAndMortyApiService();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var characters = await _apiService.GetCharactersAsync();
                characterListView.ItemsSource = characters;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error al cargar datos: {ex.Message}", "OK");
            }
        }
    }
}