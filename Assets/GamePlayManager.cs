using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variables.Scripts.VariableBase.Variables;

public class GamePlayManager : MonoBehaviour
{
    public IntVariable numberOfBallsInsideCup;
    public void OnBallEnterCup()
    {
        numberOfBallsInsideCup.Value++;
    }
    
}
