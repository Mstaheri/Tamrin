using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cart
{
    public interface ICartUpdate
    {
        public OperationResult Update(Product product);
    }
    public interface ICartInsert
    {
        public OperationResult Insert(Product product);
    }
    public interface ICartSelect
    {
        public OperationResult<List<Product>> Select();
    }
    public interface ICartDelete
    {
        public OperationResult Delete(string name);
    }

}
