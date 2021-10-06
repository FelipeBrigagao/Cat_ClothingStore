using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerSetup
{
    public float playerSpeed;

    public int playerInventoryMaxSlotAmount;

    public PlayerSetup()
    {

    }

    public PlayerSetup(float playerSpeed, int inventorySlots)
    {
        this.playerSpeed = playerSpeed;

        this.playerInventoryMaxSlotAmount = inventorySlots;

    }
}