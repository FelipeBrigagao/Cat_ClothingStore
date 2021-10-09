using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : Interactable
{
    #region Variables
    [SerializeField]
    GameObject _doorOpen;

    [SerializeField]
    GameObject _doorClosed;

    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public override void Interact()
    {
        if (_doorOpen.activeInHierarchy)
        {
            _doorClosed.SetActive(true);
            _doorOpen.SetActive(false);
        }
        else
        {
            _doorClosed.SetActive(false);
            _doorOpen.SetActive(true);

        }

    }

    #endregion


}
