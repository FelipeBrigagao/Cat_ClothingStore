using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBase<GameManager>
{
    #region Variables

    #endregion


    #region Unity Methods

    private void Start()
    {
        GameStart();
    }

    #endregion


    #region Methods

    public void GameStart()
    {
        PlayerManager.Instance.SetPlayerStats();
    }

    #endregion
}
