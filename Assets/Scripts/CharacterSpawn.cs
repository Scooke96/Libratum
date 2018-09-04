using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour 
{

	private int active1, active2, active3, active4;
	public static int activePlayers;
	public GameObject player1, player2, player3, player4, health1, health2, health3, health4;

	// Use this for initialization
	void Start () 
	{
		active1 = PlayerPrefs.GetInt ("Player1Active");
		active2 = PlayerPrefs.GetInt ("Player2Active");
		active3 = PlayerPrefs.GetInt ("Player3Active");
		active4 = PlayerPrefs.GetInt ("Player4Active");

		if (active1 == 1)
		{
			player1.gameObject.SetActive (true);
			health1.gameObject.SetActive (true);
			Movement.player1Health = 3;
		}

		if (active2 == 1)
		{
			player2.gameObject.SetActive (true);
			health2.gameObject.SetActive (true);
			Movement.player2Health = 3;
		}

		if (active3 == 1)
		{
			player3.gameObject.SetActive (true);
			health3.gameObject.SetActive (true);
			Movement.player3Health = 3;
		}

		if (active4 == 1)
		{
			player4.gameObject.SetActive (true);
			health4.gameObject.SetActive (true);
			Movement.player4Health = 3;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
