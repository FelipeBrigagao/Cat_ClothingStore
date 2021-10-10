
public class CurrencyManager : SingletonBase<CurrencyManager>
{
    #region Variables
    

    public int _currentMoney { get; private set;}

    #endregion

    #region Unity Methods
    #endregion

    #region Methods

    public void SetInitialMoneyAmount(int initialMoney)
    {
        _currentMoney = initialMoney;
        UIManager.Instance.UpdateMoneyUI(_currentMoney);
    }

    public void AddMoney(int moneyAdded)
    {
        _currentMoney += moneyAdded;
        UIManager.Instance.UpdateMoneyUI(_currentMoney);
    }

    public void RemoveMoney(int moneyRemoved)
    {
        _currentMoney -= moneyRemoved;
        UIManager.Instance.UpdateMoneyUI(_currentMoney);

    }

    

    #endregion

}
