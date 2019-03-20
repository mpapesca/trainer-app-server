using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace trainer_app_server.Models
{
    public class UserType
    {

        // Properties

        public int UserTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Title { get; set; }


        // References
        public ICollection<User> Users { get; set; }


    }
}