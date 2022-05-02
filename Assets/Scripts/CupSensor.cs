using System;
using System.Collections;
using System.Collections.Generic;
using ProjectArchitectureBase.BaseScriptsRuntime.Event;
using UnityEngine;

public class CupSensor : MonoBehaviour
{
    public VoidEvent onBallEnterCup;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.tag = "WinnerBall";
            onBallEnterCup.Raise();
        }
    }
}
