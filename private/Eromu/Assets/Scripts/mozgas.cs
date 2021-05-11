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
    public GameObject FirePoint;

    private bool playerMoving;
    private bool playerJumping;
    private Vector2 lastMove;
    private bool playerFirePointMovingRight = false;
    private bool playerFirePointMovingLeft = false;

    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update
    void Update()
    {
        playerMoving = false;
        
        Jump();

        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            playerFirePointMovingLeft = false;
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            
            if (!playerFirePointMovingRight)
            {
                FirePoint.transform.Rotate(0f, 180f, 0f);
                playerFirePointMovingRight = true;
            }
        }
        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            playerFirePointMovingRight = false;
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);

            if (!playerFirePointMovingLeft)
            {
                FirePoint.transform.Rotate(0f, -180f, 0f);
                playerFirePointMovingLeft = true;
            }
        }
        if (Input.GetButtonDown("Jump"))
        {
            playerJumping = true;
            a.SetBool("Jumping", playerJumping);
        }
        else if (Input.GetButtonUp("Jump"))
        {
            playerJumping = false;
            a.SetBool("Jumping", playerJumping);
        }


        a.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        a.SetFloat("Height", Input.GetAxisRaw("Vertical"));
        a.SetBool("Moving", playerMoving);
        a.SetFloat("LastMove", lastMove.x);
        
    }

    // Jump
    void Jump()
    {
        playerMoving = false;
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, magasság), ForceMode2D.Impulse); 
        }
    }
}
