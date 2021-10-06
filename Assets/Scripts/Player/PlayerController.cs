using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [Header("Player setup")]
    [SerializeField]
    private PlayerSetup _playerSetup;

    [Header("References")]
    private Rigidbody2D _rigidbody;

    private PlayerAnimation _playerAnim;

    [Header("Player values")]
    private Vector2 _input;


    #endregion


    #region Unity Methods
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        _playerAnim = GetComponent<PlayerAnimation>();
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
        _rigidbody.MovePosition(_rigidbody.position +  (_input.normalized * _playerSetup.playerSpeed * Time.fixedDeltaTime));

        _playerAnim?.MovementAnimation(_input);

    }


    #endregion

}
