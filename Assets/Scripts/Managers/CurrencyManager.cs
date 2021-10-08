using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : SingletonBase<CurrencyManager>
{
    #region Variables
    [Header("Money variables")]
    [SerializeField]
    private Text _currentMoneyUI;

    public int _currentMoney { get; private set;}

    #endregion

    #region Unity Methods
    #endregion

    #region Methods

    public void SetInitialMoneyAmount(int initialMoney)
    {
        _currentMoney = initialMoney;
        UpdateMoneyUI();
    }

    public void AddMoney(int moneyAdded)
    {
        _currentMoney += moneyAdded;
        UpdateMoneyUI();
    }

    public void RemoveMoney(int moneyRemoved)
    {
        _currentMoney -= moneyRemoved;
        UpdateMoneyUI();

    }

    private void UpdateMoneyUI()
    {
        _currentMoneyUI.text = $"$ {_currentMoney.ToString()}";
    }

    #endregion

}
