using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.Exeptions
{
    public class DuplicatingProductException : ApplicationException
    {
        public DuplicatingProductException(string message) : base(message)
        {

        }
    }


}