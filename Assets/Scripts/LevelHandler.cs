using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{
    [Tooltip("assign the desire settings here")]
    public LevelSettings myLevelSettings;
    [Tooltip("please don't change this variable")]
    public LevelSettings currentLevelSettings;
    private void Awake()
    {
        currentLevelSettings.Copy(myLevelSettings);
    }
}
