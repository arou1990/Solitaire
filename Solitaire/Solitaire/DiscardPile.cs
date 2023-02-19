using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire;

public class DiscardPile : PileBase
{
    public List<Card> GetAll()
    {
        return Cards.ToList();
    }
}
