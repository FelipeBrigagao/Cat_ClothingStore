using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipUI : MonoBehaviour
{
    #region Variables
    [Header("Equipment slots references")]
    [SerializeField]
    private InventorySlotBase _headInventorySlot;
    [SerializeField]
    private InventorySlotBase _chestInventorySlot;

    private PlayerEquip _playerEquip;

    #endregion

    #region Unity Methods
    private void Awake()
    {
        _playerEquip = PlayerEquip.Instance;
    }

    private void OnEnable()
    {
        _playerEquip.OnEquipmentChange += UpdatePlayerEquipUI;
        UpdatePlayerEquipUI();
    }

    private void OnDisable()
    {
        _playerEquip.OnEquipmentChange -= UpdatePlayerEquipUI;
    }
    #endregion

    #region Methods

    public void UpdatePlayerEquipUI()
    {
        if(_playerEquip._headItem != null)
        {
            _headInventorySlot.AddItemSlot(_playerEquip._headItem);
        }
        else
        {
            _headInventorySlot.ClearSlot();
        }

        if (_playerEquip._chestItem != null)
        {
            _chestInventorySlot.AddItemSlot(_playerEquip._chestItem);
        }
        else
        {
            _chestInventorySlot.ClearSlot();
        }

    }



    #endregion
}
