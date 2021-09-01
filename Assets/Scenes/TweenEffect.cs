using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenEffect : MonoBehaviour
{

    public Vector2 initialPostion;
    public Transform targetPosition;

    public float duration;
    public Ease easeBegin;
    public Ease easeExit;

    void Start()
    {
        initialPostion = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToTarget()
    {
        transform.DOLocalMove(targetPosition.localPosition, duration, false).SetEase(easeBegin);
    }

    public void MoveToInitial()
    {
        transform.DOLocalMove(initialPostion, duration, false).SetEase(easeExit);
    }
}
