using Disney.Core.Interfaces;
using System;

namespace Disney.Core.Entities
{
    public class User : BaseEntity, IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DischargeDate { get; set; }
        public bool active { get; set; }

    }
}
