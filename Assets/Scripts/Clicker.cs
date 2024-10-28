using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Remoting.Lifetime;

public class Clicker : MonoBehaviour
{
    [Header("Animation settings")]
    public float scale = 1.2f;
    public float duratino = 0.1f;
    public Ease ease;


    private int clicks = 0;

    private void OnMouseDown()
    {
        clicks++;
        UiManager.instance.UpdateClicker(clicks);
        transform.DOScale(1, duratino).ChangeStartValue(scale * Vector3.one).SetEase(ease);
    }
}
