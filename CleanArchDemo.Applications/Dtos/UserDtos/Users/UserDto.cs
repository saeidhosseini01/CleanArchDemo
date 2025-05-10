using CleanArchDemo.Domain.ValueObject.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanArchDemo.Applications.Dtos.UserDtos.Users
{
    public class UserDto(Id id,Name name,Email email,Age age)
    {
        [JsonPropertyName("id")]
        public int Id { get; } = id;
        [JsonPropertyName("Name")]
        public string Name { get; } = name;

        [JsonPropertyName("Age")]
        public int Age { get; } = age;

        [JsonPropertyName("Email")]
        public string Email { get; } = email;
    }
}
