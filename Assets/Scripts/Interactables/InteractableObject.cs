using UnityEngine;

public class InteractableObject : Interactable
{
    #region Variables
    [SerializeField] private GameObject _objectOpen;
    [SerializeField] private string _openAudioKey;
    [SerializeField] private GameObject _objectClosed;
    [SerializeField] private string _closeAudioKey;

    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    public override void Interact()
    {
        if (_objectOpen.activeInHierarchy)
        {
            _objectClosed.SetActive(true);
            _audio.PlayUserAudio(_closeAudioKey);
            _objectOpen.SetActive(false);
        }
        else
        {
            _objectClosed.SetActive(false);
            _audio.PlayUserAudio(_openAudioKey);
            _objectOpen.SetActive(true);

        }

    }

    #endregion


}
