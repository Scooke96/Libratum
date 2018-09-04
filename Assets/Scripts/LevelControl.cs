using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour 
{
	public GameObject 
	Pause = null,
	Pause2 = null,
	Option = null;

	public Camera Main;

	public Slider volume = null;

	public bool active = false;

	public void LoadScene(string levelName)
	{
		SceneManager.LoadScene(levelName);
	}

	public void CharacterLoadScene (string levelName)
	{
		if (CharacterDetect.activePlayers >= 2)
		{
			SceneManager.LoadScene (levelName);
		}
	}

	public void BackToMenu()
	{
		SceneManager.LoadScene("MainMenu");
		PlayerPrefs.SetInt ("Player1Active", 0);
		PlayerPrefs.SetInt ("Player2Active", 0);
		PlayerPrefs.SetInt ("Player3Active", 0);
		PlayerPrefs.SetInt ("Player4Active", 0);
	}
	public void QuitRequest()
	{
		Application.Quit();
	}


	public void AdjustVolume (float newValue)
	{
		float newVol = AudioListener.volume;
		newVol = newValue;
		AudioListener.volume = newVol;
		PlayerPrefs.SetFloat ("Player Volume", AudioListener.volume);
	}

	void Awake()
	{
		if (volume != null) 
		{
			volume.value = PlayerPrefs.GetFloat("Player Volume");
		}
	}
		
	void Update()
	{
		if (active == false) 
		{
			if (Input.GetKeyDown (KeyCode.Escape)) 
			{
				Pause.SetActive (true);
				active = true;
				Time.timeScale = 0;
			}
		} 
		else if (active == true) 
		{
			if (Input.GetKeyDown (KeyCode.Escape)) 
			{
				Pause.SetActive (false);
				active = false;
				Time.timeScale = 1;
			}
		}
	}

	public void Options()
	{
		Pause2.gameObject.SetActive (false);
		Option.gameObject.SetActive (true);
	}

	public void Back()
	{
		Pause2.gameObject.SetActive (true);
		Option.gameObject.SetActive (false);
	}
	public void SetInactive()
	{
		Pause.SetActive (false);
		active = false;
		Time.timeScale = 1;
	}

	public void Fullscreen()
	{
		Screen.fullScreen = !Screen.fullScreen;
	}

	public void ReloadScene()
	{
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
	}
}
