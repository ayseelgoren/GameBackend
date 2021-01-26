using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public abstract class BaseManager : ICRUD
    {
        public virtual void Create(IEntity partner)
        {
            Console.WriteLine(partner.Name + " eklendi.");
        }

        public virtual void Delete(IEntity partner)
        {

            Console.WriteLine(partner.Name + " silindi.");
        }

        public virtual void Update(IEntity partner)
        {
            Console.WriteLine(partner.Name + " güncellendi.");
        }
    }
}
