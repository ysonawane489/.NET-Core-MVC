using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        private int id;
        private string name;

       public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }


    }
}
