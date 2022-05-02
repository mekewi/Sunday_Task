using System;
using System.Collections;
using System.Collections.Generic;
using ProjectArchitectureBase.BaseScriptsRuntime.Event;
using UnityEngine;
using Variables.Scripts.VariableBase.Variables;

public class GamePlayManager : MonoBehaviour
{
    public IntVariable numberOfBallsInsideCup;
    public VoidEvent levelWin;
    public VoidEvent levelFail;
    private int NumberOfBallsOutOfCub;
    public LevelSettings levelSettings;

    private void Awake()
    {
        numberOfBallsInsideCup.Value = 0;
    }

    public void OnBallEnterCup()
    {
        numberOfBallsInsideCup.Value++;
        CheckWinLose();
    }

    public void OnBallOutOfCub()
    {
        NumberOfBallsOutOfCub++;
        CheckWinLose();
    }

    public void CheckWinLose()
    {
        if (numberOfBallsInsideCup.Value >= levelSettings.NumberOfBallsToWin)
        {
            levelWin.Raise();
            return;
        }
        var ballsSum = numberOfBallsInsideCup.Value + NumberOfBallsOutOfCub;
        if (ballsSum >= levelSettings.NumberOfBallsInGame)
        {
            levelFail.Raise();
        }
    }

}
