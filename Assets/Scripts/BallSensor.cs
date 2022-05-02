using System;
using System.Collections;
using System.Collections.Generic;
using ProjectArchitectureBase.BaseScriptsRuntime.Event;
using UnityEngine;

public class BallSensor : MonoBehaviour
{
    public Transform cub;
    public VoidEvent OnBallOutOfCub;

    private void Awake()
    {
        cub = GameObject.FindWithTag("Cub").transform;
    }

    private void Update()
    {
        if (cub == null)
        {
            return;
        }
        if (transform.position.y < cub.position.y-1)
        {
            OnBallOutOfCub.Raise();
            Destroy(gameObject);
        }
    }
}
