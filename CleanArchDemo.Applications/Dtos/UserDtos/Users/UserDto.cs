using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Dtos.UserDtos.Users
{
    public class UserDto
    {
        [JsonPropertyName("id")]
        public Double Id { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Age")]
        public double Age { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }
    }
}
