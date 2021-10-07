using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventorySlot : InventorySlotBase
{
    #region Variable
    [Header("Inventory reference")]
    private ShopInventory _shopInventory;

    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public void Sell()
    {
        bool itemSold;

        itemSold = _shopInventory.AddItem(item);

        if (itemSold)
        {
            PlayerInventory.Instance.RemoveItem(item);
        }


    }

    public void Buy()
    {
        bool itemBought;

        itemBought = PlayerInventory.Instance.AddItem(item);

        if (itemBought)
        {
            _shopInventory.RemoveItem(item);
        }
    }

    public void SetShopInventoryInstance(ShopInventory shopInventory)
    {
        _shopInventory = shopInventory;
    }
    #endregion
}
