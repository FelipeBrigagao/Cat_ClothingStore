using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region Variables
    private Vector2 _input;

    private PlayerController _playerController;

    #endregion


    #region Unity Methods

    private void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }


    #endregion


    #region Methods

    #endregion
}
