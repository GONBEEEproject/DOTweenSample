using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceMove : MonoBehaviour
{
    public void StartSequence()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(transform.DOMove(new Vector3(5, 0, 5), 3f).SetRelative());
        seq.Join(transform.DORotate(new Vector3(0, 360, 0), 3f, RotateMode.LocalAxisAdd).SetRelative());
        seq.Append(transform.DOScale(new Vector3(2, 1, 5), 1f));

        seq.Insert(2.5f, transform.DOMoveY(10, 0.5f).SetRelative());
        seq.Prepend(transform.DOMove(new Vector3(-5, 0, -5), 1f));
    }
}
