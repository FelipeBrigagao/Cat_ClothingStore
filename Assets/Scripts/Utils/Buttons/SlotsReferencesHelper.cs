using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsReferencesHelper : MonoBehaviour
{
    [Header("Slots References")]
    [SerializeField] private Transform _slotsHolder;
    private InventorySlotBase[] _slots;

    [Header("Audio reference")]
    [SerializeField] private AudioUser _audio;
    private void Awake()
    {
        _slots = _slotsHolder.GetComponentsInChildren<InventorySlotBase>();
        SetAudioUser();
    }

    private void SetAudioUser()
    {
        foreach(InventorySlotBase slot in _slots)
        {
            slot.SetAudioInstance(_audio);
        }
    }

}
