using UnityEngine;

public class ShopCatInteractable : Interactable
{
    #region Variables
    [Header("Shop inventory references")]
    [SerializeField] private GameObject _shopInventoryUI;
    [SerializeField] private string _openShopAudioKey;
    private UIManager _uiManager;

    #endregion

    #region Unity Methods
    private void Start()
    {
        _uiManager = UIManager.Instance;
    }
    #endregion


    #region Methods
    public override void Interact()
    {
        if(!_uiManager._shopIsOpen && !_uiManager._playerInventoryIsOpen)
        {
            _audio.PlayUserAudio(_openShopAudioKey);
            _uiManager.OpenShop(_shopInventoryUI);
        }      
    }
    
    #endregion


}
