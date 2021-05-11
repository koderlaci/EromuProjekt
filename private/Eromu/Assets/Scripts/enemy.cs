using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    //public float speed;
    //public bool MoveRight;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    if (MoveRight)
    //    {
    //        transform.Translate(2 * speed * Time.deltaTime, 0, 0);
    //    }
    //    else
    //    {
    //        transform.Translate(-2 * speed * Time.deltaTime, 0, 0);
    //    }
    //}

    //void OnTriggerEnter2D(Collider2D trig)
    //{
    //    if (trig.gameObject.CompareTag("Turn"))
    //    {
    //        if (MoveRight)
    //        {
    //            MoveRight = false;
    //        }
    //        else
    //        {
    //            MoveRight = true;
    //        }
    //    }
    //}
}


