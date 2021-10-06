using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerSetup
{
    public float playerSpeed;

    public PlayerSetup()
    {

    }

    public PlayerSetup(float speed)
    {
        playerSpeed = speed;
    }
}