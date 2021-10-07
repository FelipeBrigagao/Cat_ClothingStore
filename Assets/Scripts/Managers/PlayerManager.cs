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
        
        _playerController?.SetSpeed(_playerSetup.playerSpeed);
        PlayerInventory.Instance.SetSlotAmount(_playerSetup.playerInventoryMaxSlotAmount);
    }

    public void EnableMovement()
    {
        CanMove = true;
    }
    
    public void DisableMovement()
    {
        CanMove = false;
    }


    #endregion
}
