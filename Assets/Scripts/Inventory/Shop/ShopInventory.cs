using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : InventoryBase
{
    #region Variables
    [Header("Shop references")]
    [SerializeField]
    private ShopSetup _shopSetup;

    #endregion

    #region Unity Methods

    private void Start()
    {
        InitiateInventory();
    }

    #endregion

    #region Methods

    private void InitiateInventory()
    {
        SetSlotAmount(_shopSetup.shopMaxItens);
        PopulateShopInventory();
    }

    private void PopulateShopInventory()
    {
        bool itemAdded;

        foreach(Item item in _shopSetup.initialShopItens)
        {
            itemAdded = AddItem(item);

            if (!itemAdded)
            {
                Debug.Log("Shop inventory is full.");

                return;
            }
            
        }
    }

    #endregion

}
