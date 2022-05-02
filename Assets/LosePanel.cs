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
        titleImage.transform.DOScale(1.5f, 0.4f).SetLoops(4,LoopType.Yoyo);
        button.transform.DOScale(1.2f, 0.3f).SetLoops(2,LoopType.Yoyo);
    }
}
