
public class PlayerInventoryUI : InventoryUIBase
{
    #region Variables
    #endregion

    #region Unity Methods
    protected override void Awake()
    {
        base.Awake();

        _inventory = PlayerInventory.Instance;

    }
    #endregion

    #region Methods
    #endregion
}
