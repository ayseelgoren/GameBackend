using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class GamerManager : BaseManager 
    {
        private IValidateService _validateService;

        public GamerManager(IValidateService validateService)
        {
            _validateService = validateService;
        }

        public override void Create(IEntity partner)
        {
            if (_validateService.Validate(partner) )
            {
                base.Create(partner);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }

           
        }
    }
}
