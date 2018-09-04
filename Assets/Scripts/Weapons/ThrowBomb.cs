using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBomb : MonoBehaviour {

	public float throwForce = 40f;
	public GameObject bomb;
	public GameObject throwPoint, PlayerSword;
	private GameObject player;
	private Movement Mm;




	void Start()
	{
		player = transform.root.gameObject;
		Mm = player.GetComponent<Movement> ();
	}
	// Use this for initialization
	void Update () 
	{
		if (player.name == "Player1")
		{
			if (Input.GetAxis ("Fire1_P1") > 0) {
				ThrowGrenade ();
			}
		}
		else if (player.name == "Player2")
		{
			if (Input.GetAxis ("Fire1_P2") > 0) {
				ThrowGrenade ();
			}
		}
		else if (player.name == "Player3")
		{
			if (Input.GetAxis ("Fire_P3") > 0) {
				ThrowGrenade ();
			}
		}
		else if (player.name == "Player4")
		{
			if (Input.GetAxis ("Fire_P4") > 0) {
				ThrowGrenade ();
			}
		}

	}

	void ThrowGrenade()
	{
		GameObject instantiatedProjectile = Instantiate(bomb,throwPoint.gameObject.transform.position,gameObject.transform.rotation)as GameObject;
		Rigidbody2D rb = instantiatedProjectile.GetComponent<Rigidbody2D> ();
		if(Mm.facingright)
			rb.AddForce(transform.right * throwForce, ForceMode2D.Impulse);
		else if(Mm.facingright == false)
			rb.AddForce(-transform.right * throwForce, ForceMode2D.Impulse);
		
		gameObject.SetActive (false);
		PlayerSword.SetActive(true);
	}

}