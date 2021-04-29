using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mozgas : MonoBehaviour
{
    // Start is called before the first frame update
    public float sebesség = 7f;
    public float magasság = 5f;

    private Animator a;
    public float moveSpeed;

    private bool playerMoving;
    private bool playerJumping;
    private Vector2 lastMove;

    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update
    void Update()
    {
        playerMoving = false;
        playerJumping = false;
        Jump();
        //Vector3 mozgás = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += mozgás * Time.deltaTime * sebesség;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        a.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        //a.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        a.SetBool("Moving", playerMoving);
        a.SetFloat("LastMove", lastMove.x);
        a.SetBool("Jumping", playerJumping);
    }

    // Jump
    void Jump()
    {
        playerMoving = false;
        playerJumping = false;
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, magasság), ForceMode2D.Impulse);
            playerJumping = true;
        }
    }
}
