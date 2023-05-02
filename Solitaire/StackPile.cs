using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire;

    public class StackPile : PileBase
    {
    public StackPile(string location) : base(location)
    {
    }

    public bool HasNoHiddenCards()
        {
            return !Any() || Cards.All(x => x.IsVisible);
        }

    public int Count()    
        {
            return Cards.Count();
        }

    public List<Card> GetAllCards()    
        {
            return Cards;
        }
}
    