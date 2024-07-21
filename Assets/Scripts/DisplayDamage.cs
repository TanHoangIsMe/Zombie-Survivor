using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas splashCanvas;
    [SerializeField] float playTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        splashCanvas.enabled = false;
    }

    public void TurnOnSplashCanvas()
    {
        StartCoroutine(PlaySplashCanvas());
    }

    private IEnumerator PlaySplashCanvas()
    {
        splashCanvas.enabled = true;
        yield return new WaitForSeconds(playTime);
        splashCanvas.enabled = false;
    }
}
