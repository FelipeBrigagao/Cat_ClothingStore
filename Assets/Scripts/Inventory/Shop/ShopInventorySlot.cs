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

    }

    public void Buy()
    {

    }

    public void SetShopInventoryInstance(ShopInventory shopInventory)
    {
        _shopInventory = shopInventory;
    }
    #endregion
}
