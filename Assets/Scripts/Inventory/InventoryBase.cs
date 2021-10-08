using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBase : MonoBehaviour
{
    #region Variables

    [Header("Inventory values")]
    public List<Item> itens = new List<Item>();

    private int _maxInventorySlotsSpace;

    private float _updateUIDelay = 0.001f;

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

            Invoke(nameof(ItemChanged), _updateUIDelay);

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
