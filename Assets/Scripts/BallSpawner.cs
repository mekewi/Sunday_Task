using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variables.Scripts.VariableBase.Variables;
using Random = UnityEngine.Random;

public class BallSpawner : MonoBehaviour
{
    public LevelSettings levelSettings;
    public GameObject ballPrefab;
    public float radius;
    private void Awake()
    {
        StartCoroutine(InstantiateNewBalls());
    }

    public IEnumerator InstantiateNewBalls()
    {
        for (int i = 0; i < levelSettings.NumberOfBallsInGame; i++)
        {
            var newBall = Instantiate(ballPrefab);
            newBall.transform.parent = transform;
            newBall.transform.localPosition = Random.insideUnitSphere * radius;
            newBall.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            yield return new WaitForFixedUpdate();
        }
    }
}
