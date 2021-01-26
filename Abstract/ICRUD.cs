using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public interface ICRUD
    {
        void Update(IEntity partner);
        void Delete(IEntity partner);
        void Create(IEntity partner);

        //void Detail();
    }
}
