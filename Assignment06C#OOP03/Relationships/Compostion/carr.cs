using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06C_OOP03.Relationships.Compostion
{
    public class carr
    {
        public Engin Engin { get; set; }

        public Carr ()
        {
            Engin = new Engin();
        }

        public void Start()
        {
            Engin.Run();
        }
    }
}
