using UnityEngine;
using System.Collections;
using PlayerModel;

public class PlayerController : MonoBehaviour
{
	[SerializableField] private RigidBody2D rigidBody;
	[SerializableField] private Animator playerAnimation;
	private PlayerModel player;

    void Start ()
    {
        rigidBody = GetComponent<RigidBody2D>();
        playerAnimation = GetComponent<Animator>();
        player = new PlayerModel();
        PlayerModel.SetLifesAtLevelBegin();
    }
  
    void Update ()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D other)
    {
    	
    }
}