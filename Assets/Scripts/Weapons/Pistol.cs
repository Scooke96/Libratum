using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour {

	public Rigidbody2D projectile;
	public GameObject PlayerSword, Gun;
	public float speed = 20, waitingTime;
	public bool canshoot;
	public int ammo = 10;

	private GameObject Player;
	// Use this for initialization
	void Start ()
	{
		Player = transform.root.gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Player.name == "Player1")
		{
			if (Input.GetAxis ("Fire1_P1") > 0)
			{
				if (canshoot)
				{
					Shoot ();
					StartCoroutine (Wait (waitingTime));
					canshoot = false;
				}
			}
		}

		else if (Player.name == "Player2")
		{
			if (Input.GetAxis ("Fire1_P2") > 0)
			{
				if (canshoot)
				{
					Shoot ();
					StartCoroutine (Wait (waitingTime));
					canshoot = false;
				}
			}
		}
		else if (Player.name == "Player3")
		{
			if (Input.GetAxis ("Fire_P3") > 0)
			{
				if (canshoot)
				{
					Shoot ();
					StartCoroutine (Wait (waitingTime));
					canshoot = false;
				}
			}
		}
		else if (Player.name == "Player4")
		{
			if (Input.GetAxis ("Fire_P4") > 0)
			{
				if (canshoot)
				{
					Shoot ();
					StartCoroutine (Wait (waitingTime));
					canshoot = false;
				}
			}
		}
		if (ammo <= 0) 
		{
			PlayerSword.SetActive (true);
			Gun.SetActive (false);
		}

	}

	void Shoot()
	{
		Rigidbody2D instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody2D;
		instantiatedProjectile = instantiatedProjectile.GetComponent<Rigidbody2D> ();
		instantiatedProjectile.AddForce (transform.forward * speed);
		ammo--;
	}

	IEnumerator Wait(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		canshoot = true;
	}
}
