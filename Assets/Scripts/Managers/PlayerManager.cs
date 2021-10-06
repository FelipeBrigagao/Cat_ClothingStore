using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : SingletonBase<PlayerManager>
{
    #region Variables
    [Header("Player references")]
    [SerializeField]
    private GameObject _currentPlayer;

    [SerializeField]
    private PlayerSetup _playerSetup;

    private PlayerController _playerController;
    private InventoryPlayer _playerInventory;
    public bool CanMove { get; private set; }


    #endregion


    #region Unity Methods

    private void Start()
    {
        CanMove = true;
    }

    #endregion


    #region Methods

    public void SetPlayerStats()
    {
        _playerController = _currentPlayer.GetComponent<PlayerController>();
        _playerInventory = _currentPlayer.GetComponent<InventoryPlayer>();

        _playerController?.SetSpeed(_playerSetup.playerSpeed);
        _playerInventory?.SetSlotAmount(_playerSetup.playerInventoryMaxSlotAmount);

    }

    #endregion
}
