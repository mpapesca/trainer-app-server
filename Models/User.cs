using System;
using Microsoft.EntityFrameworkCore;

namespace trainer_app_server.Models
{
    public class User
    {
        // Properties

        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserTypeId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // References

        public UserType UserType { get; set; }

    }
}