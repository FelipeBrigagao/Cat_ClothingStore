using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSlotsHelper : MonoBehaviour
{
    #region Variables
    [Header("Slots reference")]
    [SerializeField]
    private Transform _slotsHolder;
   
    private ShopInventorySlot[] slots;

    [SerializeField]
    private ShopInventory _shopInventory;

    #endregion

    #region Unity Methods
    private void Awake()
    {
        slots = _slotsHolder.GetComponentsInChildren<ShopInventorySlot>();
        _shopInventory = this.GetComponentInParent<ShopInventory>();
        SetShopInventorySlotReferences();
    }

    #endregion

    #region Methods

    private void SetShopInventorySlotReferences()
    {
        foreach(ShopInventorySlot slot in slots)
        {
            slot.SetShopInventoryInstance(_shopInventory);
        }
    }

    #endregion
}
