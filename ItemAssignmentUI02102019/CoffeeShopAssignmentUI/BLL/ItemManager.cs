using CoffeeShopAssignmentUI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopAssignmentUI.BLL
{
    
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public void AddItem()
        {
            _itemRepository.AddItem();
        }
    }
}
