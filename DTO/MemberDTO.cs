using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirepitAPI.DTO
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KnownAs { get { return $"{FirstName} {LastName}"; } }
        public DateTime Created { get; set; } 
        public DateTime LastActive { get; set; } 
        public string Bio { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public ICollection<PhotoDTO> Photos { get; set; }
    }

    public class MemberUpdateDTO
    {
        public string Bio { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
