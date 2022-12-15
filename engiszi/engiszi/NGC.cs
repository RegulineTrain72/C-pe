using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpzh
{
    internal class engiszi
    {
        public string type { get; set; }
        public float mood { get; set; }

        public engiszi()
        {
            Random random = new Random();
            float rnd = (float)(random.NextDouble() * 100);
            if (rnd <= 20)
            {
                this.type = "pessimist";
            }
            else if (rnd > 20 && rnd <= 87)
            {
                this.type = "ordinary";
            }
            else
            {
                this.type = "optimist";
            }

            switch (type)
            {
                case "ordinary":
                    this.mood = (float)(random.NextDouble() * 100);
                    break;
                case "optimist":
                    this.mood = (float)(60 + random.NextDouble() * 40);
                    break;
                case "pessmist":
                    this.mood = (float)(random.NextDouble() * 20);
                    break;
            }
        }
    }
}