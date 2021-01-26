using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{

    //Oyuncu
    public class Gamer : IEntity
    {

        public string NationalityNumber { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }


        public int Id { get; set; }
        public string Name { get; set; }
    }
}
