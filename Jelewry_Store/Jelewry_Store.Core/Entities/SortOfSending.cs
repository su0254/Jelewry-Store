using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jelewry_Store.Core.Entities
{
    public enum SortsSending { BYSHOP, BYHOME, EXPRESE }
    public enum Areas { NOURTH, SOUTH, CENTER }
    public enum SpaicelCondition { FRAGILE, WRAP }
    public class SortOfSending
    {
        public int Id { get; set; }
        public string SendingCode { get; set; }
        public SortsSending DescraptionSending { get; set; }
        public int NumOfDays { get; set; }
        public Areas EAreas { get; set; }
        public double Price { get; set; }
        public int MaxItem { get; set; }
        public SpaicelCondition Conditions { get; set; }

    }
}
