using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using HotelReservaciones.Controlador;
using Xamarin.Forms;

namespace HotelReservaciones.Vistas
{
    public partial class HabitacionesHotel : ContentPage
    {
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Datos.Habitacion> _post;

        public HabitacionesHotel(string idHotel)
        {
            InitializeComponent();
            listarHabitaciones(idHotel);

        }

        public async void listarHabitaciones(string idHotel)
        {
            Service servicio = new Service();

            string url = servicio.urlGetHotelHabitacion().ToString()+idHotel;
            var content = await client.GetStringAsync(url);

            if (content.Contains("[") && content.Contains("]"))
            {

            }
            else
            {
                content = "[" + content + "]";
            }
          
            List<Datos.Habitacion> posts = JsonConvert.DeserializeObject<List<Datos.Habitacion>>(content);
            _post = new ObservableCollection<Datos.Habitacion>(posts);
            ListHotel.ItemsSource = _post;
        }


       
    }
}

