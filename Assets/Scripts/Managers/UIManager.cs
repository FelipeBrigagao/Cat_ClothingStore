using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : SingletonBase<UIManager>
{
    #region Variables
    [Header("UI elements references")]
    [SerializeField]
    private GameObject _playerInventoryUI;

    [SerializeField]
    private GameObject _playerInventoryButtonUI;

    public bool _shopIsOpen { get; private set;}

    public bool _playerInventoryIsOpen { get; private set;}

    #endregion

    #region Unity Methods
    #endregion

    #region Methods

    public void OpenPlayerInventory()
    {
        if (!_shopIsOpen)
        {
            _playerInventoryUI.SetActive(true);
            _playerInventoryButtonUI.SetActive(false);
            _playerInventoryIsOpen = true;
            PlayerManager.Instance.DisableMovement();
        }
        
    }

    public void ClosePlayerInventory()
    {
        Panel inventory;

        inventory = _playerInventoryUI.GetComponent<Panel>();

        if (inventory)
        {
            inventory.HidePanel();
        }
        else
        {
            _playerInventoryUI.SetActive(false);
        }

        _playerInventoryButtonUI.SetActive(true);
        _playerInventoryIsOpen = false;
        PlayerManager.Instance.EnableMovement();
    }

    public void OpenShop()//Esse seria bom ter um return bool
    {
        if (!_playerInventoryIsOpen)
        {
            _shopIsOpen = true;
            _playerInventoryButtonUI.SetActive(false);
            PlayerManager.Instance.DisableMovement();
        }
        
    }

    public void CloseShop()
    {
        _shopIsOpen = false;
        _playerInventoryButtonUI.SetActive(true);
        PlayerManager.Instance.EnableMovement();
    }

    #endregion
}
