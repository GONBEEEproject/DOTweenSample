using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public void StartPath()
    {
        Vector3[] path = new Vector3[3];
        path[0] = new Vector3(5, 0, -5);
        path[1] = new Vector3(2, 0, 4);
        path[2] = new Vector3(-5, 0, -3);

        transform.DOPath(path, 6f,PathType.Linear);
        transform.DOPath(path, 6f, PathType.CatmullRom);
        transform.DOPath(path, 6f, PathType.CubicBezier);
    }
}
