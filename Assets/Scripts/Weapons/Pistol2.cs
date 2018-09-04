

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pistol2 : MonoBehaviour 
{
	public static float damage = 1;
	public Rigidbody projectile;
	public float speed = 20, waitingTime;
	public bool 
	facingLeft,
	facingRight,
	facingDown,
	canShoot;
	public GameObject player;

	//public bool AxisInUse = false;
	//public bool AxisInUse1 = false;



	void Update ()
	{
//		if (Input.GetAxisRaw ("Fire1") != 0)
//		{
//			if (AxisInUse == false)
//			{
//				Shoot();
//				AxisInUse = true;
//			}
//		}
//		if (Input.GetAxisRaw ("Fire1") == 0)
//		{
//			AxisInUse = false;
//		}
//
//		if (Input.GetAxisRaw ("Fire2") != 0)
//		{
//			if (AxisInUse1 == false)
//			{
//				Shoot();
//				AxisInUse1 = true;
//			}
//		}
//		if (Input.GetAxisRaw ("Fire2") == 0)
//		{
//			AxisInUse1 = false;
//		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			player.transform.rotation = Quaternion.AngleAxis (-90, Vector3.up);
		}

		if(Input.GetKey(KeyCode.RightArrow))
		{
			player.transform.rotation = Quaternion.AngleAxis (90, Vector3.up);
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			player.transform.rotation = Quaternion.AngleAxis (180, Vector3.up);
		}

		if(Input.GetKey(KeyCode.UpArrow))
		{
			player.transform.rotation = Quaternion.AngleAxis (0, Vector3.up);
		}
			
		if(Input.GetKey(KeyCode.Space))
		{
			
		}


	}

	void Shoot()
	{
		Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
	}

	IEnumerator Wait(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		canShoot = true;
	}
}