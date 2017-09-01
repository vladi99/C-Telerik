using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForDefiningClasses
{
    public class Display
    {
        //problem 1
        private string size;
        private string numbersOfColors;
        private string v1;
        private string v2;

        public Display(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        //problem 5
        public string Size { get; set; }

        public string Colors { get; set; }
    }
}
