using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Variables.Scripts.VariableBase.Variables;

public class LevelUI : MonoBehaviour
{
    public TMP_Text level;
    public IntVariable numberOfPlayedLevels;
    public void OnLevelLoaded()
    {
        level.text = "Level " + numberOfPlayedLevels.Value;
    }
}
