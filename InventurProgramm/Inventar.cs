using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventurProgramm
{
    class Inventar
    {
        private List<Geraet> allItems;


        //normale funktionen
        public void addItem(Geraet geraet)
        {
            this.allItems.Add(geraet);
        }

        public void removeItem(Geraet geraet)
        {
            this.allItems.Remove(geraet);
        }


        public void updateItem(Geraet old_item, Geraet new_item)
        {
            foreach(Geraet geraet in allItems)
            {
                if(geraet.getInventurnummer() == old_item.getInventurnummer())
                {
                    geraet.setTyp(new_item.getTyp());
                    geraet.setBezeichnung(new_item.getBezeichnung());
                    geraet.setHersteller(new_item.getHersteller());
                    geraet.setKaufdatum(new_item.getKaufdatum());
                    geraet.setSeriennummer(new_item.getSeriennummer());
                }
            }
        }


        //getter und setter
        public List<Geraet> getAllItems()
        {
            return this.allItems;
        }
        public void setAllItems(List<Geraet> new_list)
        {
            this.allItems = new_list;
        }

        //konstruktor
        public Inventar()
        {
            this.allItems = new List<Geraet>();
         
        }
    }
}
