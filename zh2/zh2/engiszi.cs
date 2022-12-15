using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh2
{
    internal class engiszi
    {
        public string type { get; set; }
        public int mood { get; set; }

        public engiszi()
        {
            Random rnd = new Random();
            float k = (float)(rnd.NextDouble() * 100);
            if (k <= 20)
            {
                this.type = "pessimist";
            }
            else if (k > 20 && k <= 87)
            {
                this.type = "ordinary";
            }
            else
            {
                this.type = "optimist";
            }
            if (type == "ordinary")
            {
                this.mood = (int)(rnd.NextDouble() * 100);
            }
            else if (type == "pessimist")
            {
                this.mood = (int)(rnd.NextDouble() * 20);
            }
            else
                this.mood = (int)(rnd.NextDouble() * 40);
        }
    }
}