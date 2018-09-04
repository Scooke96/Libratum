using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public AudioSource hurt;

	void OnTriggerEnter2D (Collider2D other)
	{
		
		if (other.gameObject.tag == "Player 1") 
		{
			hurt.Play ();
			Movement.player1Health -= 1;
			Movement.P1Attacked = true;
		}
		else if (other.gameObject.tag == "Player 2") 
		{
			hurt.Play ();
			Movement.player2Health -= 1;
			Movement.P2Attacked = true;
		}
		else if (other.gameObject.tag == "Player 3") 
		{
			hurt.Play ();
			Movement.player3Health -= 1;
			Movement.P3Attacked = true;
		}
		else if (other.gameObject.tag == "Player 4") 
		{
			hurt.Play ();
			Movement.player4Health -= 1;
			Movement.P4Attacked = true;
		}
		Destroy (gameObject);
	}

}
