using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

	public float delay = 3f, blastRadius;

	float countdown;

	public GameObject effect;
	private Rigidbody2D rb;


	// Use this for initialization
	void Start ()
	{
		countdown = delay;
	}
	
	// Update is called once per frame
	void Update ()
	{
		countdown -= Time.deltaTime;

		if (countdown <= 0f)
		{
			Explode ();
		}
			
	}

	void Explode()
	{
		Instantiate (effect, transform.position, transform.rotation);

		Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, blastRadius);

		foreach (Collider2D nearbyObject in colliders)
		{
			if (nearbyObject.name == "Player1")
			{
				Movement.player1Health -= 1;
				Movement.P1Attacked = true;
			} 
			else if (nearbyObject.name == "Player2") 
			{
				Movement.player2Health -= 1;
				Movement.P2Attacked = true;
			} 
			else if (nearbyObject.name == "Player3")
			{
				Movement.player3Health -= 1;
				Movement.P3Attacked = true;
			} 
			else if (nearbyObject.name == "Player4") 
			{
				Movement.player4Health -= 1;
				Movement.P4Attacked = true;
			}

		}

		Destroy (gameObject);
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, blastRadius);
	}

}
