using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BobaAlphaThreshold : MonoBehaviour
{
    private Image _bobaImage;

    private void Awake()
    {
        _bobaImage = GetComponent<Image>();
        _bobaImage.alphaHitTestMinimumThreshold = 0.001f;
    }
}
