using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventoryUI : InventoryUIBase
{
    #region Variable
    #endregion

    #region Unity Methods
    protected override void Awake()
    {
        base.Awake();

        _inventory = GetComponentInParent<ShopInventory>();

    }
    #endregion

    #region Methods
    #endregion
}
