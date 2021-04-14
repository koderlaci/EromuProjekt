using UnityEngine;
using System.Collections;

/// <summary>  
/// Class for modelling Player objects
/// </summary> 

public class PlayerModel : MonoBehaviour
{
	private static int lifes;
	private int hitponts;
	public static int Hitpoints { get; }
	private IWeapon currentWeapon;

	// Init:
	private PlayerModel ()
	{
		this.hitponts = 100;
		this.currentWeapon = new Pistol();
	}
	
	// Factory:
	public void createPlayerModel ()
	{
		if (this.lifes > 0) 
		{
			return new PlayerModel();
		}
		else
		{
			return null; // Game Over
		}
	}
	
	// Lose hitpoints method:
	public void LoseHitpoints(int damage)
	{
		if (this.hitponts - damage > 0) 
		{
			this.hitponts = this._hitponts - damage;
		}
		else
		{
			this.hitponts = 0;
		}
	}
	
	// Lose one life method:
	public void LoseOneLife()
	{
		this.lifes = this.lifes - 1;
	}
	
	// At the beginning of each level, set lifes value
	public static void SetLifesAtLevelBegin()
	{
		this.lifes = 3;
	}
}