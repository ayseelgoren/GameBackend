using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public interface IValidateService
    {
        bool Validate(IEntity entity);
    }
}
