using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBase : MonoBehaviour
{
    #region Variables

    private int _maxInventorySlotsSpace;

    public List<Item> itens = new List<Item>();

    #endregion


    #region Events

    public event Action OnItemChange;

    public void ItemChanged()
    {
        OnItemChange?.Invoke();
    }

    #endregion


    #region Unity Methods
    #endregion


    #region Methods

    public bool AddItem(Item item)
    {
        if(itens.Count <= _maxInventorySlotsSpace)
        {
            itens.Add(item);

            ItemChanged();

            return true;
        }

        return false;
    }

    public void RemoveItem(Item item)
    {
        itens.Remove(item);

        ItemChanged();

    }

    public void SetSlotAmount(int slotAmount)
    {
        _maxInventorySlotsSpace = slotAmount;
    }

    #endregion
}
