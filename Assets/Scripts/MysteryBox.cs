using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour 
{
	public GameObject[] Player1Weapons,Player2Weapons,Player3Weapons,Player4Weapons;
	public GameObject Player1Sword,Player2Sword,Player3Sword,Player4Sword;
	public static int weaponChoice1, weaponChoice2, weaponChoice3, weaponChoice4; 

	void OnCollisionEnter2D (Collision2D other)
	{
		Debug.Log ("AHHHHHHHHHHH2");
		if (other.gameObject.tag == "Player 1") 
		{
			Debug.Log (weaponChoice1);
			Player1Weapons [weaponChoice1].gameObject.SetActive (false);
			weaponChoice1 = Random.Range (0, Player1Weapons.Length);
			Player1Weapons [weaponChoice1].gameObject.SetActive (true);
			Player1Sword.SetActive (false);
			Destroy (gameObject);
		}

		if (other.gameObject.tag == "Player 2") 
		{
			Debug.Log (weaponChoice2);
			Player2Weapons [weaponChoice2].gameObject.SetActive (false);
			weaponChoice2 = Random.Range (0, Player2Weapons.Length);
			Player2Weapons [weaponChoice2].gameObject.SetActive (true);
			Player2Sword.SetActive (false);
			Destroy (gameObject);
		}

		if (other.gameObject.tag == "Player 3") 
		{
			Debug.Log (weaponChoice3);
			Player3Weapons [weaponChoice3].gameObject.SetActive (false);
			weaponChoice3 = Random.Range (0, Player3Weapons.Length);
			Player3Weapons [weaponChoice3].gameObject.SetActive (true);
			Player3Sword.SetActive (false);
			Destroy (gameObject);
		}

		if (other.gameObject.tag == "Player 4") 
		{
			Debug.Log (weaponChoice4);
			Player4Weapons [weaponChoice4].gameObject.SetActive (false);
			weaponChoice4 = Random.Range (0, Player4Weapons.Length);
			Player4Weapons [weaponChoice4].gameObject.SetActive (true);
			Player4Sword.SetActive (false);
			Destroy (gameObject);
		}
	}
}
