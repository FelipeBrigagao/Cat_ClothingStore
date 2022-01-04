using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public int price = 0;
    public ItemTypes itemType;
    public AudioInfo equipAudioInfo;
    public AudioInfo unequipAudioInfo;

    public virtual void UseItem()
    {
        Debug.Log($"Item {name} used.");
    }

    public virtual void RemoveItem()
    {
        Debug.Log($"Item {name} removed.");
    }    
}

#region Enum item types
public enum ItemTypes
{
    CLOTHING,
    WEAPON

}
#endregion
