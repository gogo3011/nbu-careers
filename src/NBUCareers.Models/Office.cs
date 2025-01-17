﻿namespace NBUCareers.Models
{
    using Base;

    public class Office : Entity
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
