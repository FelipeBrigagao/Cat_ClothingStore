using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region Variables
    private Vector2 _playerInput;

    private PlayerController _playerController;

    [Header("Player input keys")]
    [SerializeField]
    private KeyCode _playerInventoryKey;

    [SerializeField]
    private KeyCode _interactKey;

    #endregion


    #region Unity Methods

    private void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (PlayerManager.Instance.CanMove)
        {
            GetMovementInput();
        }

        OpenInventoryInput();
    }


    #endregion


    #region Methods

    private void GetMovementInput()
    {
        _playerInput.x = Input.GetAxisRaw("Horizontal");
        _playerInput.y = Input.GetAxisRaw("Vertical");

        _playerController?.SetInput(_playerInput);

    }

    private void OpenInventoryInput()
    {
        if (Input.GetKeyDown(_playerInventoryKey))
        {
            if (UIManager.Instance._playerInventoryIsOpen)
            {
                UIManager.Instance.ClosePlayerInventory();
            }
            else 
            {
                UIManager.Instance.OpenPlayerInventory();

            }
        }
    }

    #endregion
}
