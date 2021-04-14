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
}