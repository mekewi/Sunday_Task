using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    public Image titleImage;
    public GameObject button;
    public void OnLevelLose()
    {
        titleImage.transform.localScale = Vector3.one * 0.6f;
        button.transform.localScale = Vector3.one * 0.6f;
        titleImage.transform.DOScale(1f, 0.4f).SetLoops(4,LoopType.Yoyo);
        button.transform.DOScale(1f, 0.3f).SetLoops(2,LoopType.Yoyo);
    }
}
