using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    private Image fade;

    private AudioSource source;


    private void Start()
    {
        fade = GetComponent<Image>();
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FadeIn();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            FadeOut();
        }

    }

    void FadeIn()
    {
        fade.color = new Color(1, 1, 1, 1);
        fade.DOFade(0, 1f);

        source.DOFade(1, 1f);
    }
   
    void FadeOut()
    {
        fade.color = new Color(1, 1, 1, 0);
        fade.DOFade(1, 1f);

        source.DOFade(0, 1f);
    }



}
