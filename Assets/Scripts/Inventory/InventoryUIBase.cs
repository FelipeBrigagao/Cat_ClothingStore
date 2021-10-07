using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIBase : MonoBehaviour
{
    #region Variables
    [Header ("Inventory references")]
    [SerializeField]
    private Transform _slotsHolder;

    protected InventorySlotBase[] slots;

    [SerializeField]
    protected InventoryBase _inventory;

    #endregion


    #region Unity Methods

    protected virtual void Awake()
    {
        slots = _slotsHolder.GetComponentsInChildren<InventorySlotBase>();


    }

    private void OnEnable()
    {
       _inventory.OnItemChange += UpdateInventoryUI;
        UpdateInventoryUI();
    }

    private void OnDisable()
    {
        _inventory.OnItemChange -= UpdateInventoryUI;
    }

    #endregion


    #region Methods

    private void UpdateInventoryUI()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if( i < _inventory.itens.Count)
            {
                slots[i].AddItem(_inventory.itens[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }


        }


    }

    #endregion


}
