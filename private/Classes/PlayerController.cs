using UnityEngine;
using System.Collections;
using PlayerModel;

/// <summary>
/// Player Controller osztály
/// <summary>

public class PlayerController : MonoBehaviour
{
	[SerializableField] private RigidBody2D rigidBody;
	[SerializableField] private Animator playerAnimation;
	private PlayerModel player;

	// Init
    void Start ()
    {
        rigidBody = GetComponent<RigidBody2D>();
        playerAnimation = GetComponent<Animator>();
        player = new PlayerModel();
        PlayerModel.SetLifesAtLevelBegin();
    }
  
	// Per frame
    void Update ()
    {
        
    }
	
	// Collide
	void OnTriggerEnter2D(Collider2D other)
    {
		// Enemy
    	if(other.tag == "Enemy")
    	{
    		// A player sebződik az enemy damage értékével
    		// player.LoseHitpoints(other.enemy.GetDamage());

    		if(player.Hitpoints <= 0)
    		{
    			// A játékos az előző checkpointhoz kerül vissza
    			PlayerModel.LoseOneLife();
    			player = new PlayerModel();

    			if(player == null)
    			{
    				// Game Over
    			}
    		}
    	}
		
		// Weapon
		if(other.tag == "Weapon")
		{
    		// Animáció váltás a fegyverrel
		}
		
		// Checkpoint
		if(other.tag == "Checkpoint")
    	{
    		// A respawn helye a checkpoint koordinátáin lesznek
    	}
		
		// Finish
		if(other.tag == "Finish")
    	{
    		// Betölt a főmenü
    	}
    }
}