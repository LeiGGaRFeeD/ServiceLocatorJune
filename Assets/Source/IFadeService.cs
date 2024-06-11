using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public interface IFadeService
{
    Tweener FadeIn(Image image, float duration);
    Tweener FadeOut(Image image, float duration);
}
