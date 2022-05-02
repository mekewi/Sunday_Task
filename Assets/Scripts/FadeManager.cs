using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Variables.Scripts.VariableBase.Variables;

public class FadeManager : MonoBehaviour
{
    public FloatVariable fadeDuration;
    public Image fadeImage;
    public void DoFadeIn()
    {
        fadeImage.gameObject.SetActive(true);
        fadeImage.DOFade(1, fadeDuration.Value);
    }
    public void DoFadeOut()
    {
        fadeImage.DOFade(0, fadeDuration.Value).onComplete = () =>
        {
            fadeImage.gameObject.SetActive(false); 
            fadeImage.color = Color.black;
        };
    }
}
