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
		
		if(other.tag == "Weapon")
		{
    		// Animáció váltás a fegyverrel
		}
		
		if(other.tag == "Checkpoint")
    	{
    		// A respawn helye a checkpoint koordinátáin lesznek
    	}
    }
}