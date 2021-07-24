using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    private Vector3 startPos;

    [SerializeField]
    private Ease ease;

    private void Start()
    {
        startPos = transform.position;
    }

    public void Reset()
    {
        transform.position = startPos;        
    }

    public void MoveStart()
    {
        transform.DOMove(new Vector3(1, 0, 0), 1f);
    }

    public void MoveStartRelative()
    {
        transform.DOMove(new Vector3(1, 0, 0), 3f).SetRelative();



    }

    public void MoveStartOnlyX()
    {
        transform.DOMoveX(1f, 3f).SetRelative();
        transform.DOMove(new Vector3(1, 0, 0), 3f);
    }

    public void MoveStartEase()
    {
        Tween tween = transform.DOMove(new Vector3(5, 0, 0), 3f);
        tween.SetEase(ease);
        tween.SetLoops(-1);
        tween.SetRelative();
        tween.SetDelay(5f);
    }

    public void MoveStartCallback()
    {
        Tween tween = transform.DOMove(new Vector3(1, 0, 0), 3f);
        tween.SetLoops(4);
        tween.OnStart(() =>
        {
            Debug.Log("Tween Start");
        });
        tween.OnUpdate(() =>
        {
            Debug.Log("Tween Updating");
        });
        tween.OnComplete(() =>
        {
            Debug.Log("Tween Complete");
        });
    }
}
