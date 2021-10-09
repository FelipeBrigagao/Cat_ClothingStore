using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerReferencesSetter : MonoBehaviour
{
    #region Variables
    [Header("References")]
    [SerializeField]
    private GameObject _playerInventoryUI;

    [SerializeField]
    private GameObject _playerInventoryButtonUI;

    [SerializeField]
    private GameObject _playerInteractIcon;

    [SerializeField]
    private Text _moneyUI;

    [SerializeField]
    private GameObject _currentPlayer;
    #endregion


    #region Unity Methods
    private void Awake()
    {
        SetCurrentPlayer();
        SetPlayerInventoryUI();
        SetPlayerInventoryButtonUI();
        SetMoneyUI();
        SetPlayerInteractionIcon();
    }

    #endregion

    #region Methods
    private void SetPlayerInventoryUI()
    {
        UIManager.Instance.SetPlayerInventoryUI(_playerInventoryUI);
    }

    private void SetPlayerInventoryButtonUI()
    {
        UIManager.Instance.SetPlayerInventoryButtonUI(_playerInventoryButtonUI);

    }

    private void SetCurrentPlayer()
    {
        PlayerManager.Instance.SetCurrentPlayer(_currentPlayer);
    }

    private void SetMoneyUI()
    {
        UIManager.Instance.SetMoneyUI(_moneyUI);

    }

    private void SetPlayerInteractionIcon()
    {
        UIManager.Instance.SetPlayerInteractionIcon(_playerInteractIcon);
    }

    #endregion
}
