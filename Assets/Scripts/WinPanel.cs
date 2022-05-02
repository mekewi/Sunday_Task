using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class WinPanel : MonoBehaviour
{
    public Image winTitle;
    public GameObject winButton;
    public void OnLevelWin()
    {
        winTitle.transform.localScale = Vector3.one * 0.6f;
        winButton.transform.localScale = Vector3.one * 0.6f;
        winTitle.transform.DOScale(1f, 0.4f).SetLoops(4,LoopType.Yoyo);
        winButton.transform.DOScale(1f, 0.3f).SetLoops(2,LoopType.Yoyo);
    }
}
