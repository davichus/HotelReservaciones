using System;
namespace HotelReservaciones.Controlador
{
	public class Service
	{
		

		public string urlHotel()
		{
			string url = "http://192.168.100.50/AppHotelService/Hotel.php";
			return url;

        }


        public string urlGetTipoHabitacion()
        {
            string url = "http://192.168.100.50/AppHotelService/TipoHabitacion.php";
            return url;

        }

    }
}

