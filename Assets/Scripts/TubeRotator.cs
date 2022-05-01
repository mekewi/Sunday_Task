using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variables.Scripts.VariableBase.Variables;

public class TubeRotator : MonoBehaviour
{
    public Vector2Variable inputDirection;
    public FloatVariable rotationSpeed;
    private Rigidbody body;
    private float changeInX;
    private Vector3 m_EulerAngleVelocity;
    private void Awake()
    {
        body = GetComponentInChildren<Rigidbody>();
    }
    private void Update()
    {
        changeInX += inputDirection.Value.x * rotationSpeed.Value;
        m_EulerAngleVelocity = new Vector3(0, 0, changeInX);

    }

    private void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);

        body.MoveRotation(deltaRotation);
    }
}
