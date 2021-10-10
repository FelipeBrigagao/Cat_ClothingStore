using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : SingletonBase<CameraManager>
{
    #region Variables
    [Header("Camera references")]
    [SerializeField]
    private GameObject _playerCamera;

    [SerializeField]
    private GameObject _inventoryCamera;

    #endregion

    #region Unity Methods
    #endregion

    #region Methods

    public void ChangeToPlayerCam()
    {
        _playerCamera.SetActive(true);
        _inventoryCamera.SetActive(false);
    }

    public void ChangeToInventoryCam()
    {
        _playerCamera.SetActive(false);
        _inventoryCamera.SetActive(true);
    }


    #endregion
}
