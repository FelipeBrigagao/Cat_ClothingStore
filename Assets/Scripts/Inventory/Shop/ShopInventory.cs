using UnityEngine;
using UnityEngine.UI;

public class ShopInventory : InventoryBase
{
    #region Variables
    [Header("Shop references")]
    [SerializeField]
    private ShopSetup _shopSetup;

    [SerializeField]
    private Text _storeNameField;

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
        _storeNameField.text = _shopSetup.shopName;
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
