using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordControl : MonoBehaviour 
{
	public AudioSource hurt;

	public bool
	player1,
	player2,
	player3,
	player4;

	public Animator Animation1;

	void Start()
	{
		Animation1 = GetComponent<Animator> ();
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("COLLISION");
		if(player1)
		{
			if (other.gameObject.tag == "Player 2" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing")) 
			{
				Debug.Log ("Smack");
				hurt.Play ();
				Movement.player2Health -= 1;
				Movement.P2Attacked = true;
			}
			else if (other.gameObject.tag == "Player 3" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing")) 
			{
				hurt.Play ();
				Movement.player3Health -= 1;
				Movement.P3Attacked = true;
			}
			else if (other.gameObject.tag == "Player 4" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing")) 
			{
				hurt.Play ();
				Movement.player4Health -= 1;
				Movement.P4Attacked = true;
			}
		}
		if (player2) 
		{
			if (other.gameObject.tag == "Player 1" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player1Health -= 1;
				Movement.P1Attacked = true;
			}
			else if (other.gameObject.tag == "Player 3" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player3Health -= 1;
				Movement.P3Attacked = true;
			}
			else if (other.gameObject.tag == "Player 4" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player4Health -= 1;
				Movement.P4Attacked = true;
			}
		}

		if (player3) 
		{
			if (other.gameObject.tag == "Player 1" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player1Health -= 1;
				Movement.P1Attacked = true;
			}
			else if (other.gameObject.tag == "Player 2" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player2Health -= 1;
				Movement.P2Attacked = true;
			}
			else if (other.gameObject.tag == "Player 4" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player4Health -= 1;
				Movement.P4Attacked = true;
			}
		}

		if (player3) 
		{
			if (other.gameObject.tag == "Player 1" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player1Health -= 1;
				Movement.P1Attacked = true;
			}
			else if (other.gameObject.tag == "Player 2" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player2Health -= 1;
				Movement.P2Attacked = true;
			}
			else if (other.gameObject.tag == "Player 3" && Animation1.GetCurrentAnimatorStateInfo(0).IsName("Sword Swing2")) 
			{
				hurt.Play ();
				Movement.player3Health -= 1;
				Movement.P3Attacked = true;
			}
		}
	}

}
