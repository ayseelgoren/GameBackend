using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    //Oyun
    public class Game : IEntity
    {
      
        public string Publisher { get; set; }
        public double UnitPrice { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
