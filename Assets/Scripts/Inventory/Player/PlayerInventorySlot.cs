
public class PlayerInventorySlot : InventorySlotBase
{
    #region Variables
    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public override void Use()
    {
        base.Use();

        if (item != null)
        {
            item.UseItem();
        }
    }

    #endregion
}
