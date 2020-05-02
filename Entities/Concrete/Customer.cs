using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string CustomerNo { get; set; }
        public string CardNumber { get; set; }
        public string AccountNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardPassword { get; set; }
        public string AccountPassword { get; set; }
    }
}
