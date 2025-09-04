﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowball.Domain.Aggregates.PostAggregate
{
    public class BasicInfo
    {
        private BasicInfo()
        {
            
        }
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string EmailAddress { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;
        public DateTime DateOfBirth { get; private set; }
        public string CurrentCity { get; private set; } = string.Empty;

        public static BasicInfo CreateBasicInfo(string firstName, string lastName, string emailAddress, string phone, DateTime dateOfBirth, string currentCity)
        {
            return new BasicInfo
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                Phone = phone,
                DateOfBirth = dateOfBirth,
                CurrentCity = currentCity
            };
        }
    }
}
