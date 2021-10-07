using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryUI : MonoBehaviour
{
    #region Variables

    private GameObject _slotsHolder;

    #endregion


    #region Unity Methods

    private void OnEnable()
    {
        PlayerInventory.Instance.OnItemChange += UpdateInventoryUI;
        UpdateInventoryUI();
    }

    private void OnDisable()
    {
        PlayerInventory.Instance.OnItemChange -= UpdateInventoryUI;
    }

    #endregion


    #region Methods

    private void UpdateInventoryUI()
    {

    }

    #endregion


}
