using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Errors
{
    class MaxLentBooks: Error
    {
        public MaxLentBooks() : base("Máximo de livros emprestados") { }
    }
}
