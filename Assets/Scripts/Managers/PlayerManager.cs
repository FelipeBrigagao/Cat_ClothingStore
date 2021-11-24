using UnityEngine;

public class PlayerManager : SingletonBase<PlayerManager>
{
    #region Variables
    [Header("Player references")]
    [SerializeField] 
    private GameObject _currentPlayer;

    [SerializeField]
    private PlayerSetup _playerSetup;

    private PlayerController _playerController;
    public bool CanMove { get; private set; }

    private Vector2 _playerStop = new Vector2(0, 0);

    #endregion


    #region Unity Methods

    private void Start()
    {
        CanMove = true;
    }

    private void OnEnable()
    {
        UIManager.Instance.OnInventoryOpen += DisableMovement;
    }

    private void OnDisable()
    {
        UIManager.Instance.OnInventoryOpen -= DisableMovement;
    }

    #endregion


    #region Methods

    public void SetPlayerStats()
    {
        _playerController = _currentPlayer.GetComponent<PlayerController>();
        
        _playerController?.SetSpeed(_playerSetup.playerSpeed);
        PlayerInventory.Instance.SetSlotAmount(_playerSetup.playerInventoryMaxSlotAmount);
        CurrencyManager.Instance.SetInitialMoneyAmount(_playerSetup.initialMoney);
    }

    public void EnableMovement()
    {
        CanMove = true;
    }
    
    public void DisableMovement()
    {
        CanMove = false;
        StopPlayer();
    }

    private void StopPlayer()
    {
        _playerController?.SetInput(_playerStop);
    }


    #region Player references setting
    public void SetCurrentPlayer(GameObject currentPlayer)
    {
        _currentPlayer = currentPlayer;
    }

    #endregion

    #endregion
}
