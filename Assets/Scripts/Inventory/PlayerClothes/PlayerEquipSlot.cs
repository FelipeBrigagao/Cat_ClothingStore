
public class PlayerEquipSlot : InventorySlotBase
{
    #region Variables
    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public void RemoveItemFromSlot()
    {
        if(item != null)
        {
            _audio.PlayUserAudio($"Unequip {item.itemType}");
            item.RemoveItem();
        }
    }
    #endregion
}
