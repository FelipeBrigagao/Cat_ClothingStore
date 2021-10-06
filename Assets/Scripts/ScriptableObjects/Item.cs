using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public ItemTypes itemType;
    
}


#region Enum
public enum ItemTypes
{
    CLOTHING,
    WEAPON

}
#endregion
