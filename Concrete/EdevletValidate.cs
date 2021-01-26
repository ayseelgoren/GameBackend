using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class EdevletValidate : IValidateService
    {
        public bool Validate(IEntity entity)
        {
            Console.WriteLine("Doğrulama gerçekleştirilmiştir.");
            return true;
        }
    }
}
