using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class To : MonoBehaviour
{
    private int startInt = 0;

    private int score;

    private Text text;
    private void Start()
    {
        text = GetComponent<Text>();
    }

    public void Reset()
    {
        score = startInt;
    }


    private void Update()
    {
        text.text = score.ToString();
    }

    public void StartTo()
    {
        DOTween.To(
            () => score,
            x => score = x,
            500,
            3f);
    }
}
