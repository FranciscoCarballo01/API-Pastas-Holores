﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client : User
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Id { get; set; }
    }
}
