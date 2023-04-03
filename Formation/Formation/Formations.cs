using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    public class Formations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  int     IdNAME { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
