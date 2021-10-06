using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBase : MonoBehaviour
{
    #region Variables

    private int _maxInventorySlotsSpace;

    public List<Item> itens = new List<Item>();

    #endregion


    #region Unity Methods
    #endregion


    #region Methods

    public bool Additem(Item item)
    {
        if(itens.Count <= _maxInventorySlotsSpace)
        {
            itens.Add(item);
            return true;
        }

        return false;
    }

    public void Removeitem(Item item)
    {
        itens.Remove(item);
    }

    public void SetSlotAmount(int slotAmount)
    {
        _maxInventorySlotsSpace = slotAmount;
    }

    #endregion
}
