using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotBase : MonoBehaviour
{
    #region Variables
    [Header("Slot references")]
    [SerializeField]
    private Image icon;

    protected Item item;

    #endregion


    #region UnityMethods
    #endregion


    #region Methods

    public virtual void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public virtual void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }

    public void Use()
    {

    }

    #endregion

}
