using System;
using System.Collections.Generic;

namespace Milio.API.Dtos
{
    public class ClientForDetailedtDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string AboutMe { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
        public string Address { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
    }
}