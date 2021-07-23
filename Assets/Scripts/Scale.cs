using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private Vector3 startScale;

    private void Start()
    {
        startScale = transform.localScale;
    }

    public void Reset()
    {
        transform.localScale = startScale;
    }

    public void ScaleStart()
    {
        transform.DOScale(new Vector3(3, 1, 5), 3f);
    }

    public void ScaleStartMulti()
    {
        transform.DOScale(5f, 3f);
    }
}
