using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipSlot : InventorySlotBase
{
    #region Variables
    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public void RemoveItemFromSlot()
    {
        item.RemoveItem();
    }
    #endregion
}
