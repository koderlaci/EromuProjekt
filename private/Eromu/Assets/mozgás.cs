using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mozgás : MonoBehaviour
{
    // Start is called before the first frame update
    public float sebesség = 7f;
    void Start()
    {

    }
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * sebesség;
    }
}
