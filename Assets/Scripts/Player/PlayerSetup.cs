using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerSetup
{
    public float playerSpeed;
    public int playerInventoryMaxSlotAmount;
    public int initialMoney;

    public PlayerSetup()
    {
        playerSpeed = 3;
        playerInventoryMaxSlotAmount = 16;
        initialMoney = 0;
    }

    public PlayerSetup(float playerSpeed, int inventorySlots, int initialMoney)
    {
        this.playerSpeed = playerSpeed;

        this.playerInventoryMaxSlotAmount = inventorySlots;

        this.initialMoney = initialMoney;
    }
}