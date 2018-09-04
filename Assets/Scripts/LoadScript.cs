using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScript : MonoBehaviour 
{	
	public static bool firstTime = false;

	// Use this for initialization
	void Start () 
	{
		if (firstTime == false)
		{
			PlayerPrefs.SetInt ("Player1WinStreak", 0);
			PlayerPrefs.SetInt ("Player1LoseStreak", 0);
			PlayerPrefs.SetFloat ("Player1Speed", 2);
			PlayerPrefs.SetFloat ("Player1Jump", 7.5f);
			PlayerPrefs.SetInt ("Player1Health", 3);

			PlayerPrefs.SetInt ("Player2WinStreak", 0);
			PlayerPrefs.SetInt ("Player2LoseStreak", 0);
			PlayerPrefs.SetFloat ("Player2Speed", 2);
			PlayerPrefs.SetFloat ("Player2Jump", 7.5f);
			PlayerPrefs.SetInt ("Player2Health", 3);

			PlayerPrefs.SetInt ("Player3WinStreak", 0);
			PlayerPrefs.SetInt ("Player3LoseStreak", 0);
			PlayerPrefs.SetFloat ("Player3Speed", 2);
			PlayerPrefs.SetFloat ("Player3Jump", 7.5f);
			PlayerPrefs.SetInt ("Player3Health", 3);

			PlayerPrefs.SetInt ("Player4WinStreak", 0);
			PlayerPrefs.SetInt ("Player4LoseStreak", 0);
			PlayerPrefs.SetFloat ("Player4Speed", 2);
			PlayerPrefs.SetFloat ("Player4Jump", 7.5f);
			PlayerPrefs.SetInt ("Player4Health", 3);
			firstTime = true;
		}
	}
	

}
