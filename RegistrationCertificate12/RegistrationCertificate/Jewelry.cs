﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationCertificate
{
    class Jewelry : BaseClass
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }
        public DateTime DateOfCreation { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            var properties = typeof(Jewelry).GetProperties();

            string jewelry = String.Empty;

            foreach (var property in properties)
                jewelry += $"{property.Name}: {property.GetValue(this)}\n";

            return jewelry;
        }
    }
}