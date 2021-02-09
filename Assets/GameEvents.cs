using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    private void awake()
    {
        current=this;
    }
    public event Action onBallTriggerCollision;
    public void BallTriggerCollision()
    {
        if(onBallTriggerCollision != null)
        {
            onBallTriggerCollision();
        }
    }
}
