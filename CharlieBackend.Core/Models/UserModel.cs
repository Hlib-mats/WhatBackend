﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CharlieBackend.Core.Models
{
    public class UserModel
    {
        public int account_id { get; set; }
        public string login { get; set; }

        [JsonIgnore]
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
