using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    #region Variables
    [Header("Slot references")]
    [SerializeField]
    private Image icon;

    private Item item;

    #endregion


    #region UnityMethods
    #endregion


    #region Methods

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    #endregion

}
