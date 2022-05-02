using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public Transform hand;
    private bool isHandShown;
    public void OnLevelLoaded()
    {
        hand.gameObject.SetActive(true);
        isHandShown = true;
    }

    private void Update()
    {
        if (isHandShown && Input.GetMouseButtonDown(0))
        {
            hand.gameObject.SetActive(false);
            isHandShown = false;
        }
    }
}
