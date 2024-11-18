﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jelewry_Store.Core.Entities
{
    public enum Status { WORKER, CLIENT, MANEGER }
    public class User
    {
        public int Id { get; set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string? ZipCode { get; set; }
        public DateTime BirthDay { get; set; }
        public Status? EStatus { get; set; }

    }
}
