using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameSettings/LevelSettings",fileName = "LevelSettings")]
public class LevelSettings : ScriptableObject
{
    public int NumberOfBallsInGame;
    public int NumberOfBallsToWin;

    public void Copy(LevelSettings levelSettings)
    {
        NumberOfBallsInGame = levelSettings.NumberOfBallsInGame;
        NumberOfBallsToWin = levelSettings.NumberOfBallsToWin;
    }
}
