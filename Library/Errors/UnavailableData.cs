using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Errors
{
    class UnavailableData: Error
    {
        public UnavailableData() : base("Data indisponível") { }
    }
}
