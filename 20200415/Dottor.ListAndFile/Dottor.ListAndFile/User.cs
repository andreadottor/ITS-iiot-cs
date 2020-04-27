﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dottor.ListAndFile
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User()
        {

        }

        public User(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
