using System;

namespace AbstructFactory
{
    public class Greet : ICloneable
    {
        public string Morning { get; set; }

        public string Afternoon { get; set; }

        public string Night { get; set; }

        public Greet(string morning, string afternoon, string night)
        {
            Morning = morning;
            Afternoon = afternoon;
            Night = night;
        }

        public object Clone()
        {
            return new Greet(Morning, Afternoon,null);

            //return this.MemberwiseClone();
        }
    }
}