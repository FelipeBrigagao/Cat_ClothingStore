using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : Item
{
    public ClothingTypes clothingType;

    public override void UseItem()
    {
        base.UseItem();

        PlayerEquip.Instance.AddEquipment(this);
        PlayerInventory.Instance.RemoveItem(this);
    }

    public override void RemoveItem()
    {
        base.UseItem();

        PlayerEquip.Instance.RemoveEquipment(this);
    }

}

#region Enum Clothing types
public enum ClothingTypes
{
    HEAD,
    CHEST
}
#endregion