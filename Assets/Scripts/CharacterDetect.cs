using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDetect : MonoBehaviour {

	public GameObject player1,player2,player3,player4, press1, press2, press3, press4, ready1, ready2, ready3, ready4;

	public bool active1,active2,active3,active4;

	public static int activePlayers;
	// Use this for initialization
	void Awake () 
	{
		PlayerPrefs.SetInt ("Player1Active", 0);
		PlayerPrefs.SetInt ("Player2Active", 0);
		PlayerPrefs.SetInt ("Player3Active", 0);
		PlayerPrefs.SetInt ("Player4Active", 0);
		player1.gameObject.SetActive (false);
		player2.gameObject.SetActive (false);
		player3.gameObject.SetActive (false);
		player4.gameObject.SetActive (false);
		activePlayers = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Jump_P1"))
		{
			PlayerPrefs.SetInt ("Player1Active", 1);
			player1.gameObject.SetActive (true);
			press1.gameObject.SetActive (false);
			ready1.gameObject.SetActive (true);
			if (active1 == false)
			{
				activePlayers += 1;
			}
			active1 = true;
		}

		if(Input.GetButtonDown("Jump_P2"))
		{
			PlayerPrefs.SetInt ("Player2Active", 1);
			player2.gameObject.SetActive (true);
			press2.gameObject.SetActive (false);
			ready2.gameObject.SetActive (true);
			if (active2 == false)
			{
				activePlayers += 1;
			}
			active2 = true;
		}

		if(Input.GetButtonDown("Jump_P3"))
		{
			PlayerPrefs.SetInt ("Player3Active", 1);
			player3.gameObject.SetActive (true);
			press3.gameObject.SetActive (false);
			ready3.gameObject.SetActive (true);
			if (active3 == false)
			{
				activePlayers += 1;
			}
			active3 = true;
		}

		if(Input.GetButtonDown("Jump_P4"))
		{
			PlayerPrefs.SetInt ("Player4Active", 1);
			player4.gameObject.SetActive (true);
			press4.gameObject.SetActive (false);
			ready4.gameObject.SetActive (true);
			if (active4 == false)
			{
				activePlayers += 1;
			}
			active4 = true;
		}
		if (Input.GetButtonDown ("Cancel"))
		{
			if (active1 == true)
			{
				PlayerPrefs.SetInt ("Player1Active", 0);
				player1.gameObject.SetActive (false);
				press1.gameObject.SetActive (true);
				ready1.gameObject.SetActive (false);
				if (active1 == true)
				{
					activePlayers -= 1;
				}
				active1 = false;
			}
		}
		if (Input.GetButtonDown ("Cancel_P2"))
		{
			if (active2 == true)
			{
				PlayerPrefs.SetInt ("Player2Active", 0);
				player2.gameObject.SetActive (false);
				press2.gameObject.SetActive (true);
				ready2.gameObject.SetActive (false);
				if (active2 == true)
				{
					activePlayers -= 1;
				}
				active2 = false;
			}
		}

		if (Input.GetButtonDown ("Cancel_P3"))
		{
			if (active3 == true)
			{
				PlayerPrefs.SetInt ("Player3Active", 0);
				player3.gameObject.SetActive (false);
				press3.gameObject.SetActive (true);
				ready3.gameObject.SetActive (false);
				if (active3 == true)
				{
					activePlayers -= 1;
				}
				active3 = false;
			}
		}

		if (Input.GetButtonDown ("Cancel_P4"))
		{
			if (active4 == true)
			{
				PlayerPrefs.SetInt ("Player4Active", 0);
				player4.gameObject.SetActive (false);
				press4.gameObject.SetActive (true);
				ready4.gameObject.SetActive (false);
				if (active4 == true)
				{
					activePlayers -= 1;
				}
				active4 = false;
			}
		}
	}
}
