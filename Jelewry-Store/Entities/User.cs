
namespace Jelewry_Store.Entities
{
    public enum Status { WORKER, CLIENT, MANEGER }
    public class User
    {
        public int Code { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string? ZipCode { get; set; }
        public DateTime BirthDay { get; set; }
        public Status EStatus { get; set; }

        public User(int code, string id, string name, string? email, string phoneNumber, string city, string address, string? zipCode, DateTime birthDay, Status status)
        {
            Code = code;
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            City = city;
            Address = address;
            ZipCode = zipCode;
            BirthDay = birthDay;
            EStatus = status;
        }
    }
}
