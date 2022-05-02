using System;
using System.Collections;
using System.Collections.Generic;
using ProjectArchitectureBase.BaseScriptsRuntime.Event;
using UnityEngine;
using Variables.Scripts.VariableBase.Variables;

public class LevelsManager : MonoBehaviour
{
    public GameLevels gameLevels;
    public FloatVariable fadeDuration;
    public GameObject currentLevel;
    public IntVariable currentLevelIndex;
    public IntVariable numberOfPlayedLevels;
    public VoidEvent onLevelLoaded;
    public VoidEvent RequestFadeIn;
    public VoidEvent RequestFadeOut;
    public void Awake()
    {
        currentLevelIndex.Value = PlayerPrefs.GetInt("CurrentLevel", 0);
        numberOfPlayedLevels.Value = PlayerPrefs.GetInt("NumberOfPlayedLevels", 1);
        currentLevelIndex.Value = Mathf.Clamp(currentLevelIndex.Value, 0, gameLevels.levels.Count);
        StartCoroutine(InstantiateLevel());
    }

    private IEnumerator InstantiateLevel()
    {
        RequestFadeIn.Raise();
        yield return new WaitForSeconds(fadeDuration.Value);
        if (currentLevel != null)
        {
            Destroy(currentLevel);
            currentLevel = null;
        }
        currentLevel = Instantiate(gameLevels.levels[currentLevelIndex.Value]);
        RequestFadeOut.Raise();
        yield return new WaitForSeconds(fadeDuration.Value);
        onLevelLoaded.Raise();
        PlayerPrefs.SetInt("CurrentLevel",currentLevelIndex.Value);
    }

    public void LoadNextLevel()
    {
        numberOfPlayedLevels.Value++;
        PlayerPrefs.SetInt("NumberOfPlayedLevels", numberOfPlayedLevels.Value);
        var nextLevelIndex = (currentLevelIndex.Value + 1) % gameLevels.levels.Count;
        currentLevelIndex.Value = nextLevelIndex;
        StartCoroutine(InstantiateLevel());
    }

    public void ReloadCurrentLevel()
    {
        StartCoroutine(InstantiateLevel());
    }
}
