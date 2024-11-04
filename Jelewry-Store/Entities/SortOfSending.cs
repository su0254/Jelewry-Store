namespace Jelewry_Store.Entities
{
    public enum SortsSending { BYSHOP, BYHOME, EXPRESE }
    public enum Areas { NOURTH, SOUTH, CENTER}
    public enum SpaicelCondition { FRAGILE, WRAP }
    public class SortOfSending
    {
        public int SendingCode { get; set; }
        public SortsSending DescraptionSending { get; set;}
        public int NumOfDays { get; set; }
        public Areas EAreas { get; set; }
        public double Price { get; set; }
        public int MaxItem { get; set; }
        public SpaicelCondition Conditions { get; set; }

    }
}
