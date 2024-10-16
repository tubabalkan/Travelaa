using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelaa.EntityLayer.Concrete
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string KullanıcıAdi { get; set; }
        public string Password { get; set; }
    }
}
