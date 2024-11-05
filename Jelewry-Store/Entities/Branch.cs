namespace Jelewry_Store.Entities
{
    public class Branch
    {
        public static int id = 0;
        public int Id { get; set; }
        public int CodeBranch { get; set; }
        public int CodeManager { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Open { get; set; }
        public string Close { get; set; }

        public Branch(int codeBranch, int codeManager, string adress, string city, string phoneNumber, string open, string close)
        {
            CodeBranch = codeBranch;
            CodeManager = codeManager;
            Adress = adress;
            City = city;
            PhoneNumber = phoneNumber;
            Open = open;
            Close = close;
        }
    }
}
