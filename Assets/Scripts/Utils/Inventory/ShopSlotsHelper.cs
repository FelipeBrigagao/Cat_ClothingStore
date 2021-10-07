using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSlotsHelper : MonoBehaviour
{
    #region Variable
    [Header("Slots reference")]
    [SerializeField]
    private Transform _slotsHolder;

    [SerializeField]
    private ShopInventory _shopInventory;

    private ShopInventorySlot[] slots;
    #endregion

    #region Unity Methods
    private void Awake()
    {
        slots = _slotsHolder.GetComponentsInChildren<ShopInventorySlot>();
    }

    #endregion

    #region Methods

    private void SetShopInventorySlotreferences()
    {
        foreach(ShopInventorySlot slot in slots)
        {
            slot.SetShopInventoryInstance(_shopInventory);
        }
    }

    #endregion
}
