using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInventorySlot : InventorySlotBase
{
    #region Variable
    [Header("Inventory reference")]
    private ShopInventory _shopInventory;

    [Header("UI references")]
    [SerializeField]
    private Text _priceTagUI;

    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public override void AddItem(Item newItem)
    {
        base.AddItem(newItem);
        _priceTagUI.enabled = true;

    }

    public override void ClearSlot()
    {
        base.ClearSlot();
        _priceTagUI.enabled = false;

    }

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
