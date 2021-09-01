using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ToastManager : MonoBehaviour
{

    public RectTransform targetPos;
    public RectTransform rect;
    public Text text;

    public static ToastManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        rect = text.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShowText(string _text,float duration,bool staysInHud)
    {
        Sequence sequence = DOTween.Sequence();
        
       
        sequence.Append(rect.DOLocalMove(targetPos.localPosition, 1).SetEase(Ease.InBack));
        sequence.AppendInterval(1f);
        sequence.AppendCallback(Hide);
    }

    public void Hide()
    {
        rect.DOLocalMove(Vector2.zero, 1, false).SetEase(Ease.OutBack);
    }
}
