using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCatInteractable : Interactable
{
    #region Variables
    [Header("Shop inventory references")]
    [SerializeField]
    private GameObject _shopInventoryUI;

    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public override void Interact()
    {
        if(!UIManager.Instance._shopIsOpen && !UIManager.Instance._playerInventoryIsOpen)
        {
            UIManager.Instance.OpenShop(_shopInventoryUI);
        }      
    }
    
    #endregion


}
