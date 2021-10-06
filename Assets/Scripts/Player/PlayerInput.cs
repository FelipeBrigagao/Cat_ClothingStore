using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region Variables
    private Vector2 _playerInput;

    private PlayerController _playerController;


    #endregion


    #region Unity Methods

    private void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        GetMovementInput();
    }


    #endregion


    #region Methods

    private void GetMovementInput()
    {
        _playerInput.x = Input.GetAxisRaw("Horizontal");
        _playerInput.y = Input.GetAxisRaw("Vertical");

        _playerController?.SetInput(_playerInput);

    }


    #endregion
}
