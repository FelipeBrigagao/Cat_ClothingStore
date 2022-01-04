using UnityEngine;
using UnityEngine.UI;

public class PlayerUIReferencesSetter : MonoBehaviour
{
    #region Variables
    [Header("References")]
    [SerializeField]
    private GameObject _playerInventoryUI;

    [SerializeField]
    private GameObject _playerInventoryButtonUI;

    [SerializeField]
    private GameObject _playerInteractIcon;

    [SerializeField]
    private Text _moneyUI;

    [SerializeField]
    private GameObject _exitGameButtonUI;

    #endregion


    #region Unity Methods
    private void Awake()
    {
        SetPlayerInventoryUI();
        SetPlayerInventoryButtonUI();
        SetMoneyUI();
        SetPlayerInteractionIcon();
        SetExitGameButtonUI();
    }

    #endregion

    #region Methods
    private void SetPlayerInventoryUI()
    {
        UIManager.Instance.SetPlayerInventoryUI(_playerInventoryUI);
    }

    private void SetPlayerInventoryButtonUI()
    {
        UIManager.Instance.SetPlayerInventoryButtonUI(_playerInventoryButtonUI);

    }

    private void SetMoneyUI()
    {
        UIManager.Instance.SetMoneyUI(_moneyUI);

    }

    private void SetPlayerInteractionIcon()
    {
        UIManager.Instance.SetPlayerInteractionIcon(_playerInteractIcon);
    }

    private void SetExitGameButtonUI()
    {
        UIManager.Instance.SetExitGameButton(_exitGameButtonUI);

    }
    #endregion
}
