using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoxControl : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "Player 1" && Movement.player1Health < 3)
		{
			Movement.player1Health += 1;
			Destroy (gameObject);
		} 
		else if (other.gameObject.tag == "Player 2" && Movement.player2Health < 3)
		{
			Movement.player2Health += 1;
			Destroy (gameObject);
		}
		else if (other.gameObject.tag == "Player 3" && Movement.player3Health < 3)
		{
			Movement.player3Health += 1;
			Destroy (gameObject);
		} 
		else if (other.gameObject.tag == "Player 4" && Movement.player4Health < 3)
		{
			Movement.player4Health += 1;
			Destroy (gameObject);
		} 
		else if (other.gameObject.tag == "Player 1" || other.gameObject.tag == "Player 2" 
			|| other.gameObject.tag == "Player 3" || other.gameObject.tag == "Player 4")
		{
			Destroy (gameObject);
		}
	}
}
