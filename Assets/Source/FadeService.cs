using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class FadeService : IFadeService
{
    public Tweener FadeIn(Image image, float duration)
    {
        return image.DOFade(1, duration);
    }

    public Tweener FadeOut(Image image, float duration)
    {
        return image.DOFade(0, duration);
    }
}
