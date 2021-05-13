using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;
    public bool isBoss;

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
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        if(isBoss)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Destroy(gameObject);
    }

    public float speed;
    public bool MoveRight;
    void Start()
    {
        if (isBoss)
            health = 5 * health;
    }

    void Update()
    {
        if (MoveRight)
        {
            transform.Translate(2 * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-2 * speed * Time.deltaTime, 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
    }
}


