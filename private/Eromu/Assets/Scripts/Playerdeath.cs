using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    //karakter hozzáér a megfelelő triggerhez és emmiatt a poziciója visszakerül a start ra
    void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.gameObject.CompareTag("Death")
        if (transform.position.x==4)
        {
            transform.position = new Vector3(-5,-2,0);
        }
    }
}
