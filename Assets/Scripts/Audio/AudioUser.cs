using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioUser : MonoBehaviour
{
    #region Variables
    [Header("Audio References")]
    [SerializeField] private AudioInfo[] _audiosInfo;
    [SerializeField] private AudioSource _audioSource;

    private Dictionary<string, AudioClip> _audioDictionary;
    #endregion

    #region Unity Methods
    private void Awake()
    {
        _audioDictionary = new Dictionary<string, AudioClip>();

        foreach(AudioInfo a in _audiosInfo)
        {
            AddAudioToDictionary(a.audioName, a.audioClip);
        }

    }

    #endregion


    #region Methods
    public void PlayUserAudio(string audioKey)
    {
        _audioSource.clip = _audioDictionary[audioKey];
        _audioSource.Play();
    }

    public void AddAudioToDictionary(string key, AudioClip audio)
    {
        if (_audioDictionary.ContainsKey(key))
        {
            Debug.Log($"Audio {key} already on the dictionary.");
            return;
        }
        _audioDictionary.Add(key, audio);
    }

    #endregion
}
