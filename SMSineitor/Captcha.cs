using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSineitor
{
    class Captcha
    {
        public int a { get; set; }
        public int b { get; set; }

        public Captcha()
        {
                       
        }

        public string Generate()
        {
            Random rnd = new Random();
            a = rnd.Next(100);
            b = rnd.Next(100);
            return base.ToString();
        }

        public bool Validate(int c) => a+b==c;
        public override string ToString()
        {
            return Convert.ToString(a) + " + " + Convert.ToString(b);
        }
    }
}
