
using System;
namespace WebApplicationNew.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
    }
}