using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    private Vector3 startPos;

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
        transform.DOMove(new Vector3(1, 0, 0), 3f);
    }

    public void MoveStartRelative()
    {
        transform.DOMove(new Vector3(1, 0, 0), 3f).SetRelative();
    }

    public void MoveStartOnlyX()
    {
        transform.DOMoveX(1f, 3f);
    }
}
