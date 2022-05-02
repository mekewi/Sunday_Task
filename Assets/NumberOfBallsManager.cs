using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberOfBallsManager : MonoBehaviour
{
    public TMP_Text count;
    public void OnBallsCountChanged(int currentCount)
    {
        count.text = currentCount.ToString();
    }
}
