using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire;

    public class StackPile : PileBase
    {
    public StackPile(string location) : base(location) { }

    public int Count()    
        {
            return Cards.Count();
        }
}
    