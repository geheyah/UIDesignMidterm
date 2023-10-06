using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Sequence = DG.Tweening.Sequence;
using DG.Tweening.Core.Easing;

public class Button : MonoBehaviour
{
    public RectTransform catt;
    public SpriteRenderer cat2;
    public Vector2 catposition = new (5,0);
    public float speed = 0.15f;
    public Vector2 catscale = new (0.7f, 0.7f);
    public RectTransform catanchor;

    public void _Bounce()
    {
        Sequence bounce = DOTween.Sequence();
        bounce.Append(catt.DOMove(catposition, speed));
        bounce.Append(catt.DOMove(new Vector2(5, -0.5f), speed).SetEase(Ease.Linear));
        bounce.Append(catt.DOMove(new Vector2(5, 0.8f), 0.3f).SetEase(Ease.Linear));
        bounce.Append(catt.DOMove(new Vector2(5, -0.5f), speed).SetEase(Ease.Linear));
        bounce.Append(catt.DOMove(catposition, speed));

    }

    public void Shake() 
    { 
        Sequence shake = DOTween.Sequence();
        shake.Append(catt.DOMove(catposition, speed));
        shake.Append(catt.DOMove(new Vector2(4, 0f), speed).SetEase(Ease.Linear));
        shake.Append(catt.DOMove(new Vector2(6, 0f), speed).SetEase(Ease.InQuad));
        shake.Append(catt.DOMove(new Vector2(4, 0f), speed).SetEase(Ease.OutQuad));
        shake.Append(catt.DOMove(new Vector2(6, 0f), speed).SetEase(Ease.Linear));
        shake.Append(catt.DOMove(catposition, speed));
    }

    public void Flash() 
    {
        Sequence flash = DOTween.Sequence();
        flash.Append(cat2.DOFade((1), 0.3f).SetEase(Ease.Linear));
        flash.Append(cat2.DOFade((0), 0.3f).SetEase(Ease.Linear));
        flash.Append(cat2.DOFade((1), 0.3f).SetEase(Ease.Linear));
        flash.Append(cat2.DOFade((0), 0.3f).SetEase(Ease.Linear));
        flash.Append(cat2.DOFade((1), 0.3f).SetEase(Ease.Linear));
    }

    public void Pulse() 
    { 
        Sequence pulse = DOTween.Sequence();
        pulse.Append(catt.DOScale((catscale), .3f).SetEase(Ease.Linear));
        pulse.Append(catt.DOScale(new Vector2 (1f,1f), .3f).SetEase(Ease.InOutQuad));
        pulse.Append(catt.DOScale((catscale), .3f).SetEase(Ease.Linear));
    }

    public void Jiggle () 
    {
        Sequence jiggle = DOTween.Sequence();
        jiggle.Append(catanchor.DOScale((new Vector2 (1,1)), speed).SetEase(Ease.Linear));
        jiggle.Append(catanchor.DOScale((new Vector2(1, 1.2f)), 0.2f).SetEase(Ease.InQuad));
        jiggle.Append(catanchor.DOScale((new Vector2(1, 0.8f)), 0.2f).SetEase(Ease.OutQuad));
        jiggle.Append(catanchor.DOScale((new Vector2(1, 1)), speed).SetEase(Ease.Linear));
    }

    public void Sway()
    {
        Sequence sway = DOTween.Sequence();
        sway.Append(catanchor.DORotate((new Vector3 (0,0,0)), speed).SetEase(Ease.Linear));
        sway.Append(catanchor.DORotate((new Vector3(0, 0, 20)), speed).SetEase(Ease.Linear));
        sway.Append(catanchor.DORotate((new Vector3(0, 0, -20)), speed).SetEase(Ease.Linear));
        sway.Append(catanchor.DORotate((new Vector3(0, 0, 10)), speed).SetEase(Ease.Linear));
        sway.Append(catanchor.DORotate((new Vector3(0, 0, -10)), speed).SetEase(Ease.Linear));
        sway.Append(catanchor.DORotate((new Vector3(0, 0, 0)), speed).SetEase(Ease.Linear));
    }
}
