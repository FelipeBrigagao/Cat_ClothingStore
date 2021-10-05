using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup
{
    public float playerSpeed;

    public int playerInventoryMaxItens;

    public PlayerSetup()
    {

    }

    public PlayerSetup(float speed, int maxItens)
    {
        playerSpeed = speed;

        playerInventoryMaxItens = maxItens;
    }
}