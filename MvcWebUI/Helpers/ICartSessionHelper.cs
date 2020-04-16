using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Helpers
{
    public interface ICartSessionHelper
    {
        Cart GetCart(string key);
        void SetCard(string key, Cart cart);
        void Clear();
    }
}
