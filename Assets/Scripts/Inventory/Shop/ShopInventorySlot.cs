using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopInventorySlot : InventorySlotBase
{
    #region Variables
    [Header("Inventory reference")]
    private ShopInventory _shopInventory;

    [Header("UI references")]
    [SerializeField]
    private Text _priceTagUI;

    [SerializeField]
    private Color _notEnoughtMoneyColor; 
    [SerializeField]
    private Color _enoughtMoneyColor; 

    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public override void AddItemSlot(Item newItem)
    {
        base.AddItemSlot(newItem);

        _priceTagUI.enabled = true;

        _priceTagUI.text = $"$ {item.price}";
        
        if(item.price <= CurrencyManager.Instance._currentMoney)
        {
            _priceTagUI.color = _enoughtMoneyColor;

        }else if(item.price > CurrencyManager.Instance._currentMoney)
        {
            _priceTagUI.color = _notEnoughtMoneyColor;

        }
        

    }


    public override void ClearSlot()
    {
        base.ClearSlot();
        _priceTagUI.text = null;
        _priceTagUI.enabled = false;

    }

    public void Sell()
    {
        if (item != null)
        {
            bool itemSold;

            itemSold = _shopInventory.AddItem(item);

            if (itemSold)
            {
                CurrencyManager.Instance.AddMoney(item.price);

                PlayerInventory.Instance.RemoveItem(item);
            }

        }
    }

    public void Buy()
    {
        if (item != null)
        {
            if(item.price <= CurrencyManager.Instance._currentMoney)
            {
                bool itemBought;
                itemBought = PlayerInventory.Instance.AddItem(item);

                if (itemBought)
                {
                    CurrencyManager.Instance.RemoveMoney(item.price);

                    _shopInventory.RemoveItem(item);
                }

            }

        }

    }

    public void SetShopInventoryInstance(ShopInventory shopInventory)
    {
        _shopInventory = shopInventory;
    }
    #endregion
}
