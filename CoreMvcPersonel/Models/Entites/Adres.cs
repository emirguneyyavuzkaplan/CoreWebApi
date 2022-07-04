namespace CoreMvcPersonel.Models.Entites
{
    public enum AdresTip
    {
        Ev,
        İş,
        Yazlık,
        Diger
    }
    public class Adres
    {
        public int Id { get; set; }
        public AdresTip? AdresTip { get; set; }
        public int? SehirId { get; set; }
        public int? IlceId { get; set; }
        public string? CaddeSokak { get; set; }
    }
}