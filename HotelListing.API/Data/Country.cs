namespace HotelListing.API.Data
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string shortName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}