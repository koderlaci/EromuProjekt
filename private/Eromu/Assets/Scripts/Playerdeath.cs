using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerdeath : MonoBehaviour
{
    public GameObject player;
    public Image Fadeimg;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    //karakter hozzáér a megfelelő triggerhez és emmiatt a poziciója visszakerül a start ra
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Death")
        {
            Fadeimg.canvasRenderer.SetAlpha(1.0f);
            FadeIn();
            player.transform.position = new Vector3(-5, -2, 0);
        }
    }

    void FadeIn()
    {
        Fadeimg.CrossFadeAlpha(0, 1, false);
    }
}
