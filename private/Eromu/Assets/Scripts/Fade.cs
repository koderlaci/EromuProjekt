using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image Fadeimg;

    // Start is called before the first frame update
    void Start()
    {
        Fadeimg.canvasRenderer.SetAlpha(1.0f);
        FadeIn();
    }

    // Update is called once per frame
    void FadeIn()
    {
        Fadeimg.CrossFadeAlpha(0,10,false);
    }
}
