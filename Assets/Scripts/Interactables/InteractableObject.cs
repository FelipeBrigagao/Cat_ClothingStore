using UnityEngine;

public class InteractableObject : Interactable
{
    #region Variables
    [SerializeField]
    GameObject _objectOpen;

    [SerializeField]
    GameObject _objectClosed;

    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public override void Interact()
    {
        if (_objectOpen.activeInHierarchy)
        {
            _objectClosed.SetActive(true);
            _objectOpen.SetActive(false);
        }
        else
        {
            _objectClosed.SetActive(false);
            _objectOpen.SetActive(true);

        }

    }

    #endregion


}
