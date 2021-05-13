using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HotelApi.Models;
using HotelApi.Utilities;

namespace HotelApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HotelController : ControllerBase
    {

        List<Hotel> hotels = HotelListUtil.hotels;
        
        public HotelController()
        {

            Hotel h1 = new Hotel(1, "Hotel Transylvania", "https://en.wikipedia.org/wiki/Hotel Translyvania", "Somewhere", 5, "https://cdn.onebauer.media/one/empire-tmdb/films/76492/images/pQPRp30zd0BSaefterJnLmh4Rs9.jpg?format=jpg&quality=80&width=960&height=540&ratio=16-9&resize=aspectfill");
            Hotel h2 = new Hotel(2, "The Oyster Box", "https://oysterboxhotel.com/?utm_source=google&utm_medium=local&utm_campaign=hotel", "Umhlanga Rocks", 5, "https://cf.bstatic.com/images/hotel/max1024x768/185/185747737.jpg");
            Hotel h3 = new Hotel(3, "Protea Hotel by Marriott Johannesburg", "https://www.marriott.com/hotels/travel/jnbpa-protea-hotel-johannesburg-parktonian-all-suite/?scid=bb1a189a-fec3-4d19-a255-54ba596febe2&y_source=1_NDIyOTM5My03MTUtbG9jYXRpb24uZ29vZ2xlX3dlYnNpdGVfb3ZlcnJpZGU%3D", "Johannesburg", 4, "https://cache.marriott.com/marriottassets/marriott/JNBPA/jnbpa-entrance-0024-hor-feat.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=1180px:*");
        
            hotels.Add(h1);
            hotels.Add(h2);
            hotels.Add(h3);
        }

        [HttpGet]
        public List<Hotel> GetHotels()
        {
            return hotels;
        }

        [HttpGet]
        public Hotel GetHotel(string s){
            return hotels.Where(h => h.Name.Contains(s)).FirstOrDefault();
        }

        [HttpPost]
        public void PostHotel(Hotel h){
            hotels.Add(h);
        }
        
    }
}
