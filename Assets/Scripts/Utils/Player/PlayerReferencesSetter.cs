using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReferencesSetter : MonoBehaviour
{
    #region Variables
    [Header("References")]
    
    [SerializeField]
    private GameObject _currentPlayer;
    #endregion


    #region Unity Methods
    private void Awake()
    {
        SetCurrentPlayer();
    }

    #endregion

    #region Methods
    private void SetCurrentPlayer()
    {
        PlayerManager.Instance.SetCurrentPlayer(_currentPlayer);
    }

    #endregion
}
