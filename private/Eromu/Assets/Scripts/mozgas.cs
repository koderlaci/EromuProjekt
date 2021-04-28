using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mozgas : MonoBehaviour
{
    // Start is called before the first frame update
    public float sebesség = 7f;
    public float magasság = 5f;
    void Start()
    {

    }

    // Update
    void Update()
    {
        Jump();
        Vector3 mozgás = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += mozgás * Time.deltaTime * sebesség;
    }

    // Jump
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, magasság), ForceMode2D.Impulse);
        }
    }
}
