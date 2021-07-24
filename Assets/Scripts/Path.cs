using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField]
    private Transform[] transforms;

    public void StartPath()
    {
        Vector3[] path = new Vector3[transforms.Length];
        for (int i = 0; i < path.Length; i++)
        {
            path[i] = transforms[i].position;
        }

        //transform.DOPath(path, 6f);
        transform.DOPath(path, 6f, PathType.CatmullRom);
        //transform.DOPath(path, 6f, PathType.CubicBezier);
    }
}
