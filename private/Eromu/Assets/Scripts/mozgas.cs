using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mozgas : MonoBehaviour
{
    // Start is called before the first frame update
    public float sebesség = 7f;
    public float magasság = 5f;

    public Transform GroundCheck1;
    public LayerMask groundLayer;

    private Animator a;
    public float moveSpeed;
    public GameObject FirePoint;

    private bool playerMoving;
    private bool playerJumping;
    private float distToGround;
    private Vector2 lastMove;

    void Start()
    {

        distToGround = gameObject.GetComponent<Collider2D>().bounds.extents.y;
        a = GetComponent<Animator>();
    }

    // Update
    void Update()
    {
        playerMoving = false;
        
        Jump();

        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            
            FirePoint.transform.localPosition = new Vector3(0.350f, 0, 0);
            FirePoint.transform.rotation = new Quaternion(0,0,0,0);

        }
        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);

            FirePoint.transform.localPosition = new Vector3(-0.5f, 0, 0);
            FirePoint.transform.rotation = new Quaternion(0, 180 , 0, 0);
        }
        if (Input.GetButtonDown("Jump") && IsGrounded())
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
    bool IsGrounded() {
        return Physics2D.OverlapCircle(GroundCheck1.position, 0.15f, groundLayer);
    }
    void Jump()
    {
        playerMoving = false;
        Debug.Log(IsGrounded());
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, magasság), ForceMode2D.Impulse); 
        }
    }
}
