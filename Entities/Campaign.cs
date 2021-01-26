using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    //Kampanya
    public class Campaign : IEntity
    {
        public string Description { get; set; }
        public int Price { get; set; }


        public int Id { get; set; }
        public string Name { get; set; }
    }
}
