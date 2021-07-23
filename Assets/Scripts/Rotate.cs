using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    private Quaternion startQuat;

    private void Start()
    {
        startQuat = transform.rotation;
    }

    public void Reset()
    {
        transform.rotation = startQuat;
    }

    public void RotateStart()
    {
        transform.DORotate(new Vector3(0, 300f, 0), 3f);
    }

    public void RotateStartBeyond360()
    {
        transform.DORotate(new Vector3(0, 300f, 0), 3f, RotateMode.FastBeyond360);
    }

    public void RotateStartAxisAdd()
    {
        transform.DORotate(new Vector3(0, 300f, 0), 3f, RotateMode.LocalAxisAdd);
    }
}
