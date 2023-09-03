using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cart
{
    public class CartUpdateFile : ICartUpdate
    {
        public OperationResult Update(Product product)
        {
            // اپدیت شد
            return new OperationResult
            {
                Success = true,
            };
        }
    }
}
