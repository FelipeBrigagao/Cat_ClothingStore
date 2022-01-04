using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonBase<UIManager>
{
    #region Variables
    [Header("Inventory UI references")]
    [SerializeField]
    private GameObject _playerInventoryUI;

    private GameObject _shopInventoryUI;

    [SerializeField]
    private GameObject _playerInventoryButtonUI;

    public bool _shopIsOpen { get; private set;}

    public bool _playerInventoryIsOpen { get; private set;}

    [Header("Money UI references")]
    [SerializeField]
    private Text _currentMoneyUI;

    [Header ("Interaction UI references")]
    [SerializeField]
    private GameObject _playerInteractIcon;

    private bool _playerInteractIconWasEnabled;

    private GameObject _exitGameButton;


    #endregion

    #region Events
    public event Action OnInventoryOpen;

    public void InventoryOpened()
    {
        OnInventoryOpen?.Invoke();
    }

    #endregion

    #region Unity Methods
    #endregion


    #region Methods

    #region Inventory UI
    public void OpenPlayerInventory()
    {
        if (!_shopIsOpen)
        {
            _playerInventoryUI.SetActive(true);
            _playerInventoryButtonUI.SetActive(false);
            _exitGameButton.SetActive(false);
            _playerInventoryIsOpen = true;
            AudioManager.Instance.TurnVolumeDown();
            InventoryOpened();
            CheckInteractionIcon();
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
        _exitGameButton.SetActive(true);
        _playerInventoryIsOpen = false;
        AudioManager.Instance.TurnVolumeUp();
        CameraManager.Instance.ChangeToPlayerCam();
        ReenableInteractionIcon();
        PlayerManager.Instance.EnableMovement();
    }

    public void OpenShop(GameObject shopInventoryUI)
    {
       
        _shopInventoryUI = shopInventoryUI;
        _shopInventoryUI.SetActive(true);
        _shopIsOpen = true;
        _playerInventoryButtonUI.SetActive(false);
        _exitGameButton.SetActive(false);
        AudioManager.Instance.TurnVolumeDown();
        CheckInteractionIcon();
        PlayerManager.Instance.DisableMovement();
        
    }

    public void CloseShop()
    {
        Panel shopInventory;

        shopInventory = _shopInventoryUI.GetComponent<Panel>();

        if (shopInventory)
        {
            shopInventory.HidePanel();
        }
        else
        {
            _playerInventoryUI.SetActive(false);
        }

        _playerInventoryButtonUI.SetActive(true);
        _exitGameButton.SetActive(true);
        _shopIsOpen = false;
        AudioManager.Instance.TurnVolumeUp();
        ReenableInteractionIcon();
        PlayerManager.Instance.EnableMovement();
    }

    #endregion

    #region Currency UI

    public void UpdateMoneyUI(int currentMoney)
    {
        _currentMoneyUI.text = $"$ {currentMoney}";
    }

    #endregion


    #region Interaction UI
    public void EnableInteractIcon()
    {
        _playerInteractIcon.SetActive(true);
    }

    public void DisableInteractIcon()
    {
        _playerInteractIcon.SetActive(false);
    }

    private void CheckInteractionIcon()
    {
        if (_playerInteractIcon.activeInHierarchy)
        {
            DisableInteractIcon();
            _playerInteractIconWasEnabled = true;
        }
        else
        {
            _playerInteractIconWasEnabled = false;
        }
    }

    private void ReenableInteractionIcon()
    {
        if (_playerInteractIconWasEnabled)
        {
            EnableInteractIcon();
        }
    }

    #endregion


    #region ReferencesSetting
    public void SetPlayerInventoryUI(GameObject playerInventoryUI)
    {
        _playerInventoryUI = playerInventoryUI;
    }

    public void SetPlayerInventoryButtonUI(GameObject playerInventoryButtonUi)
    {
        _playerInventoryButtonUI = playerInventoryButtonUi;
    }

    public void SetMoneyUI(Text moneyUI)
    {
        _currentMoneyUI = moneyUI;
    }

    public void SetPlayerInteractionIcon(GameObject playerInteractionIcon)
    {
        _playerInteractIcon = playerInteractionIcon;
    }

    public void SetExitGameButton(GameObject exitButton)
    {
        _exitGameButton = exitButton;
    }

    #endregion

    #endregion
}
