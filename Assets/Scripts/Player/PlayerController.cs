using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private PlayerSetup _playerSetup;

    private Rigidbody2D _rigidbody;

    private Vector2 _input;



    #endregion


    #region Unity Methods
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }


    #endregion


    #region Methods

    public void SetInput(Vector2 input)
    {
        _input = input;
    }

    private void Move()
    {
        _rigidbody.velocity = _input.normalized * _playerSetup.playerSpeed;
    }


    #endregion

}
