
public class ShopInventoryUI : InventoryUIBase
{
    #region Variables
    #endregion

    #region Unity Methods
    protected override void Awake()
    {
        base.Awake();

        _inventory = GetComponentInParent<ShopInventory>();

    }
    #endregion


    #region Methods

    #endregion
}
