using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : SingletonBase<AudioManager>
{
    #region Variables
    [Header("Music animation")]
    [SerializeField] private Animator _audioManagerAnim;
    [SerializeField] private string _fadeInTrigger;
    [SerializeField] private string _fadeOutTrigger;


    #endregion

    #region Unity Methods
    private void Awake()
    {
        _audioManagerAnim = GetComponent<Animator>();
    }

    #endregion

    #region Methods
    public void TurnVolumeUp()
    {
        _audioManagerAnim.SetTrigger(_fadeInTrigger);
    }

    public void TurnVolumeDown()
    {
        _audioManagerAnim.SetTrigger(_fadeOutTrigger);
    }


    #endregion
}
 