namespace HotelApi.Models
{
    public class Hotel
    {

        //hotel details (name, website, city, rating, imageurl)
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string City { get; set; }
        public int Rating { get; set; }    
        public string ImageUrl { get; set; }

        public Hotel (int hotelId, string name, string website, string city, int rating, string imageurl){

            HotelId = hotelId;
            Name = name;
            Website = website;
            City = city;
            Rating = rating;
            ImageUrl = imageurl;
        }
    }
}