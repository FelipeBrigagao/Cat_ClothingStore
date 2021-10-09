using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBase<GameManager>
{
    #region Variables

    #endregion


    #region Unity Methods
    protected override void Awake()
    {
        base.Awake();

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
