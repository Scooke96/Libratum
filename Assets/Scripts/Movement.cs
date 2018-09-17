using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{
	//private SpriteRenderer SR;
	public Animator Animation1,Animation2;
	public GameObject
	PH5,
	PH4,
	PH3,
	PH2,
	PH11,
	PH21,
	PH31,
	PH41,
	Sword,
	MegaSword,
	RespawnBase,
	playerWins,
	deathEffect,
	P1,
	P2,
	P3,
	P4,
	playAgain,
	backMenu;

	public AudioSource Swing;

	public float 
	jumpForce, 
	speed,
	flipNumber;

	public static int
	player1Health = 0,
	player2Health = 0,
	player3Health = 0,
	player4Health = 0;

	public int loops = 1;
	private int
	active1,
	active2,
	active3,
	active4,
	winChange;

	public bool 
	player1,
	player2,
	player3,
	player4,
	facingright;

	private bool
	respawn1 = false,
	respawn2 = false,
	respawn3 = false,
	respawn4 = false,
	player1dead = false,
	player2dead = false,
	player3dead = false,
	player4dead = false,
	added = false,
	added2 = false;

	public static bool
	P1Attacked = false,
	P2Attacked = false,
	P3Attacked = false,
	P4Attacked = false,
	hadWinStreak = false,
	hadLoseStreak = false;

	void Start ()
	{
		added = false;
		added2 = false;

		Time.timeScale = 1;
		active1 = PlayerPrefs.GetInt ("Player1Active");
		active2 = PlayerPrefs.GetInt ("Player2Active");
		active3 = PlayerPrefs.GetInt ("Player3Active");
		active4 = PlayerPrefs.GetInt ("Player4Active");

		if (active1 == 0)
			player1dead = true;
		if (active2 == 0)
			player2dead = true;
		if (active3 == 0)
			player3dead = true;
		if (active4 == 0)
			player4dead = true;

		if (player1) {	
			if (PlayerPrefs.GetInt ("Player1WinStreak") >= 2 && PlayerPrefs.GetInt ("Player1WinStreak") <= 5)
			{
				hadWinStreak = true;
				speed = PlayerPrefs.GetFloat ("Player1Speed");
				jumpForce = PlayerPrefs.GetFloat ("Player1Jump");
				player1Health = PlayerPrefs.GetInt ("Player1Health");

				while (loops > 0)
				{
					winChange = Random.Range (1, 10);
					Debug.Log (winChange);
					if (winChange >= 1 && winChange <= 4)
					{
						speed = PlayerPrefs.GetFloat ("Player1Speed");
						Debug.Log (speed);
						speed -= 0.2f;
						PlayerPrefs.SetFloat ("Player1Speed", speed);
						loops--;
					}
					else if (winChange >= 5 && winChange <= 8)
					{
						jumpForce = PlayerPrefs.GetFloat ("Player1Jump");
						Debug.Log (jumpForce);
						jumpForce -= 0.1f;
						PlayerPrefs.SetFloat ("Player1Jump", jumpForce);
						loops--;
					}
					else if (winChange >= 9)
					{
						if (PlayerPrefs.GetInt ("Player1Health") == 3)
						{
							player1Health = PlayerPrefs.GetInt ("Player1Health") - 1;
							PlayerPrefs.SetInt ("Player1Health", player1Health);
							loops--;

						}
					} 
				}

			}
			if (PlayerPrefs.GetInt ("Player1LoseStreak") >= 2 && PlayerPrefs.GetInt ("Player1LoseStreak") <= 5)
			{
				hadLoseStreak = true;
				speed = PlayerPrefs.GetFloat ("Player1Speed");
				jumpForce = PlayerPrefs.GetFloat ("Player1Jump");
				player1Health = PlayerPrefs.GetInt ("Player1Health");
				while (loops > 0)
				{
					winChange = Random.Range (1, 10);
					if (winChange >= 1 && winChange <= 4)
					{
						speed = PlayerPrefs.GetFloat ("Player1Speed") + 0.2f; 
						PlayerPrefs.SetFloat ("Player1Speed", speed);
						loops--;
					} 
					else if (winChange >= 5 && winChange <= 8)
					{
						jumpForce = PlayerPrefs.GetFloat ("Player1Jump") + 0.1f; 
						PlayerPrefs.SetFloat ("Player1Jump", jumpForce);
						loops--;
					} 
					else if (winChange >= 9)
					{
						if (PlayerPrefs.GetInt ("Player1Health") == 3)
						{
							player1Health = PlayerPrefs.GetInt ("Player1Health") + 1;
							PlayerPrefs.SetInt ("Player1Health", player1Health);
							PH5.gameObject.SetActive (true);
							loops--;

						}
					} 
				}
			}
			if (PlayerPrefs.GetInt ("Player1WinStreak") == 0 && hadWinStreak == true)
			{
				PlayerPrefs.SetFloat ("Player1Speed", 2);
				PlayerPrefs.SetFloat ("Player1Jump", 7.5f);
				PlayerPrefs.SetInt ("Player1Health", 3);
				hadWinStreak = false;
			}

			if (PlayerPrefs.GetInt ("Player1LoseStreak") == 0 && hadLoseStreak == true)
			{
				PlayerPrefs.SetFloat ("Player1Speed", 2);
				PlayerPrefs.SetFloat ("Player1Jump", 7.5f);
				PlayerPrefs.SetInt ("Player1Health", 3);
				hadWinStreak = false;
			}
		}
	
		if (player2)
		{	
			if (PlayerPrefs.GetInt ("Player2WinStreak") >= 2 && PlayerPrefs.GetInt ("Player2WinStreak") <= 5)
			{
				hadWinStreak = true;

				speed = PlayerPrefs.GetFloat ("Player2Speed");
				jumpForce = PlayerPrefs.GetFloat ("Player2Jump");
				player2Health = PlayerPrefs.GetInt ("Player2Health");

				while (loops > 0)
				{
					winChange = Random.Range (1, 10);
					Debug.Log (winChange);
					if (winChange >= 1 && winChange <= 4)
					{
						speed = PlayerPrefs.GetFloat ("Player2Speed");
						Debug.Log (speed);
						speed -= 0.2f;
						PlayerPrefs.SetFloat ("Player2Speed", speed);
						loops--;
					} 
					else if (winChange >= 5 && winChange <= 8)
					{
						jumpForce = PlayerPrefs.GetFloat ("Player2Jump");
						Debug.Log (jumpForce);
						jumpForce -= 0.1f;
						PlayerPrefs.SetFloat ("Player2Jump", jumpForce);
						loops--;
					} 
					else if (winChange >= 9)
					{
						if (PlayerPrefs.GetInt ("Player2Health") == 3)
						{
							player2Health = PlayerPrefs.GetInt ("Player2Health") - 1;
							PlayerPrefs.SetInt ("Player2Health", player2Health);
							loops--;

						}
					} 
				}

			}
			if (PlayerPrefs.GetInt ("Player2LoseStreak") >= 2 && PlayerPrefs.GetInt ("Player2LoseStreak") <= 5)
			{
				hadLoseStreak = true;
				speed = PlayerPrefs.GetFloat ("Player2Speed");
				jumpForce = PlayerPrefs.GetFloat ("Player2Jump");
				player1Health = PlayerPrefs.GetInt ("Player2Health");

				while (loops > 0)
				{
					winChange = Random.Range (1, 10);
					if (winChange >= 1 && winChange <= 4)
					{
						speed = PlayerPrefs.GetFloat ("Player2Speed") + 0.2f; 
						PlayerPrefs.SetFloat ("Player2Speed", speed);
						loops--;
					}
					else if (winChange >= 5 && winChange <= 8)
					{
						jumpForce = PlayerPrefs.GetFloat ("Player2Jump") + 0.1f; 
						PlayerPrefs.SetFloat ("Player2Jump", jumpForce);
						loops--;
					} 
					else if (winChange >= 9) {
						if (PlayerPrefs.GetInt ("Player2Health") == 3)
						{
							player2Health = PlayerPrefs.GetInt ("Player2Health") + 1;
							PlayerPrefs.SetInt ("Player2Health", player2Health);
							PH5.gameObject.SetActive (true);
							loops--;

						}
					} 
				}
			}
			if (PlayerPrefs.GetInt ("Player2WinStreak") == 0 && hadWinStreak == true) 
			{
				PlayerPrefs.SetFloat ("Player2Speed", 2);
				PlayerPrefs.SetFloat ("Player2Jump", 7.5f);
				PlayerPrefs.SetInt ("Player2Health", 3);
				hadWinStreak = false;
			}

			if (PlayerPrefs.GetInt ("Player2LoseStreak") == 0 && hadLoseStreak == true)
			{
				PlayerPrefs.SetFloat ("Player2Speed", 2);
				PlayerPrefs.SetFloat ("Player2Jump", 7.5f);
				PlayerPrefs.SetInt ("Player2Health", 3);
				hadWinStreak = false;
			}
		}
	
		if (player3)
		{	
			if (PlayerPrefs.GetInt ("Player3WinStreak") >= 2 && PlayerPrefs.GetInt ("Player3WinStreak") <= 5)
			{
				hadWinStreak = true;
				speed = PlayerPrefs.GetFloat ("Player3Speed");
				jumpForce = PlayerPrefs.GetFloat ("Player3Jump");
				player3Health = PlayerPrefs.GetInt ("Player3Health");

				while (loops > 0)
				{
					winChange = Random.Range (1, 10);
					Debug.Log (winChange);
					if (winChange >= 1 && winChange <= 4)
					{
						speed = PlayerPrefs.GetFloat ("Player3Speed");
						Debug.Log (speed);
						speed -= 0.2f;
						PlayerPrefs.SetFloat ("Player3Speed", speed);
						loops--;
					} 

					else if (winChange >= 5 && winChange <= 8)
					{
						jumpForce = PlayerPrefs.GetFloat ("Player3Jump");
						Debug.Log (jumpForce);
						jumpForce -= 0.1f;
						PlayerPrefs.SetFloat ("Player3Jump", jumpForce);
						loops--;
					} 

					else if (winChange >= 9)
					{
						if (PlayerPrefs.GetInt ("Player3Health") == 3) {
							player3Health = PlayerPrefs.GetInt ("Player3Health") - 1;
							PlayerPrefs.SetInt ("Player3Health", player3Health);
							loops--;

						}
					} 
				}

			}
			if (PlayerPrefs.GetInt ("Player3LoseStreak") >= 2 && PlayerPrefs.GetInt ("Player3LoseStreak") <= 5) 
			{
				hadLoseStreak = true;
				speed = PlayerPrefs.GetFloat ("Player3Speed");
				jumpForce = PlayerPrefs.GetFloat ("Player3Jump");
				player1Health = PlayerPrefs.GetInt ("Player3Health");

				while (loops > 0)
				{
					winChange = Random.Range (1, 10);
					if (winChange >= 1 && winChange <= 4)
					{
						speed = PlayerPrefs.GetFloat ("Player3Speed") + 0.2f; 
						PlayerPrefs.SetFloat ("Player3Speed", speed);
						loops--;
					} 
					else if (winChange >= 5 && winChange <= 8)
					{
						jumpForce = PlayerPrefs.GetFloat ("Player3Jump") + 0.1f; 
						PlayerPrefs.SetFloat ("Player3Jump", jumpForce);
						loops--;
					} 
					else if (winChange >= 9) {
						if (PlayerPrefs.GetInt ("Player3Health") == 3)
						{
							player3Health = PlayerPrefs.GetInt ("Player3Health") + 1;
							PlayerPrefs.SetInt ("Player3Health", player3Health);
							PH5.gameObject.SetActive (true);
							loops--;

						}
					} 
				}
			}
			if (PlayerPrefs.GetInt ("Player3WinStreak") == 0 && hadWinStreak == true)
			{
				PlayerPrefs.SetFloat ("Player3Speed", 2);
				PlayerPrefs.SetFloat ("Player3Jump", 7.5f);
				PlayerPrefs.SetInt ("Player3Health", 3);
				hadWinStreak = false;
			}

			if (PlayerPrefs.GetInt ("Player3LoseStreak") == 0 && hadLoseStreak == true)
			{
				PlayerPrefs.SetFloat ("Player3Speed", 2);
				PlayerPrefs.SetFloat ("Player3Jump", 7.5f);
				PlayerPrefs.SetInt ("Player3Health", 3);
				hadWinStreak = false;
			}
		}

		if (player4) {	
			if (PlayerPrefs.GetInt ("Player4WinStreak") >= 2 && PlayerPrefs.GetInt ("Player4WinStreak") <= 5)
			{
				hadWinStreak = true;
				speed = PlayerPrefs.GetFloat ("Player4Speed");
				jumpForce = PlayerPrefs.GetFloat ("Player4Jump");
				player4Health = PlayerPrefs.GetInt ("Player4Health");

				while (loops > 0)
				{
					winChange = Random.Range (1, 10);
					Debug.Log (winChange);
					if (winChange >= 1 && winChange <= 4)
					{
						speed = PlayerPrefs.GetFloat ("Player4Speed");
						Debug.Log (speed);
						speed -= 0.2f;
						PlayerPrefs.SetFloat ("Player4Speed", speed);
						loops--;
					} 
					else if (winChange >= 5 && winChange <= 8) 
					{
						jumpForce = PlayerPrefs.GetFloat ("Player4Jump");
						Debug.Log (jumpForce);
						jumpForce -= 0.1f;
						PlayerPrefs.SetFloat ("Player4Jump", jumpForce);
						loops--;
					} 
					else if (winChange >= 9) 
					{
						if (PlayerPrefs.GetInt ("Player4Health") == 3)
						{
							player4Health = PlayerPrefs.GetInt ("Player4Health") - 1;
							PlayerPrefs.SetInt ("Player4Health", player4Health);
							loops--;

						}
					} 
				}

			}
			if (PlayerPrefs.GetInt ("Player4LoseStreak") >= 2 && PlayerPrefs.GetInt ("Player4LoseStreak") <= 5)
			{
				hadLoseStreak = true;
				speed = PlayerPrefs.GetFloat ("Player4Speed");
				jumpForce = PlayerPrefs.GetFloat ("Player4Jump");
				player1Health = PlayerPrefs.GetInt ("Player4Health");

				while (loops > 0)
				{
					winChange = Random.Range (1, 10);
					if (winChange >= 1 && winChange <= 4)
					{
						speed = PlayerPrefs.GetFloat ("Player4Speed") + 0.2f; 
						PlayerPrefs.SetFloat ("Player4Speed", speed);
						loops--;
					} 
					else if (winChange >= 5 && winChange <= 8)
					{
						jumpForce = PlayerPrefs.GetFloat ("Player4Jump") + 0.1f; 
						PlayerPrefs.SetFloat ("Player4Jump", jumpForce);
						loops--;
					}
					else if (winChange >= 9) {
						if (PlayerPrefs.GetInt ("Player4Health") == 3) 
						{
							player4Health = PlayerPrefs.GetInt ("Player4Health") + 1;
							PlayerPrefs.SetInt ("Player4Health", player4Health);
							PH5.gameObject.SetActive (true);
							loops--;

						}
					} 
				}
			}
			if (PlayerPrefs.GetInt ("Player4WinStreak") == 0 && hadWinStreak == true)
			{
				PlayerPrefs.SetFloat ("Player4Speed", 2);
				PlayerPrefs.SetFloat ("Player4Jump", 7.5f);
				PlayerPrefs.SetInt ("Player4Health", 3);
				hadWinStreak = false;
			}

			if (PlayerPrefs.GetInt ("Player4LoseStreak") == 0 && hadLoseStreak == true)
			{
				PlayerPrefs.SetFloat ("Player4Speed", 2);
				PlayerPrefs.SetFloat ("Player4Jump", 7.5f);
				PlayerPrefs.SetInt ("Player4Health", 3);
				hadWinStreak = false;
			}
		}
	}
	void Win()
	{
		if (player2dead && player3dead && player4dead)
		{
			playerWins.gameObject.SetActive (true);
			playAgain.gameObject.SetActive (true);
			backMenu.gameObject.SetActive (true);

			if (added == false)
			{
				PlayerPrefs.SetInt ("Player1WinStreak", PlayerPrefs.GetInt ("Player1WinStreak") + 1);
				PlayerPrefs.SetInt ("Player2WinStreak", 0);
				PlayerPrefs.SetInt ("Player3WinStreak", 0);
				PlayerPrefs.SetInt ("Player4WinStreak", 0);
				added = true;
			}
		}

		else if (player1dead && player3dead && player4dead)
		{
			playerWins.gameObject.SetActive (true);
			playAgain.gameObject.SetActive (true);
			backMenu.gameObject.SetActive (true);
			if (added == false) 
			{
				PlayerPrefs.SetInt ("Player2WinStreak", PlayerPrefs.GetInt ("Player2WinStreak") + 1);
				PlayerPrefs.SetInt ("Player1WinStreak", 0);
				PlayerPrefs.SetInt ("Player3WinStreak", 0);
				PlayerPrefs.SetInt ("Player4WinStreak", 0);
			}
		}

		else if (player1dead && player2dead && player4dead)
		{
			playerWins.gameObject.SetActive (true);
			playAgain.gameObject.SetActive (true);
			backMenu.gameObject.SetActive (true);
			if (added == false)
			{
				PlayerPrefs.SetInt ("Player3WinStreak", PlayerPrefs.GetInt ("Player3WinStreak") + 1);
				PlayerPrefs.SetInt ("Player1WinStreak", 0);
				PlayerPrefs.SetInt ("Player2WinStreak", 0);
				PlayerPrefs.SetInt ("Player4WinStreak", 0);
			}
		}

		else if (player1dead && player2dead && player3dead)
		{
			playerWins.gameObject.SetActive (true);
			playAgain.gameObject.SetActive (true);
			backMenu.gameObject.SetActive (true);
			if (added == false)
			{
				PlayerPrefs.SetInt ("Player4WinStreak", PlayerPrefs.GetInt ("Player4WinStreak") + 1);
				PlayerPrefs.SetInt ("Player1WinStreak", 0);
				PlayerPrefs.SetInt ("Player2WinStreak", 0);
				PlayerPrefs.SetInt ("Player3WinStreak", 0);
			}
		}
	}


	void Respawn()
	{
		Instantiate (deathEffect, transform.position, transform.rotation);
		gameObject.transform.position = RespawnBase.transform.position;
		gameObject.transform.position += transform.up * 1.2f;
	}
		
	// Update is called once per frame
	void Update () 
	{
		Win ();

		if (player1)
		{
			if (Input.GetAxis ("Horizontal_P1") > 0) {
				gameObject.transform.position += transform.right * Time.deltaTime * speed;
				if (facingright != true)
				{
					//SR.flipX = false;
					transform.localScale += new Vector3 (+flipNumber,0,0);
					facingright = true;
				}
			}

			if (Input.GetAxis ("Horizontal_P1") < 0) {
				gameObject.transform.position += -transform.right * Time.deltaTime * speed;
				if (facingright == true) 
				{
					//SR.flipX = true;
					transform.localScale += new Vector3 (-flipNumber,0,0);
					facingright = false;
				}
			}
			if (Input.GetAxis ("Jump_P1") > 0 && GetComponent<Rigidbody2D> ().velocity.y == 0) 
			{
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
			} 
			if (Sword.activeSelf == true)
			{
				if (Input.GetAxis ("Fire1_P1") > 0 && Animation1.GetCurrentAnimatorStateInfo (0).IsName ("New State"))
				{
					Debug.Log ("SwingP1");
					Swing.Play ();
					Animation1.SetTrigger ("ButtonPress");
				}
			}
			else if (MegaSword.activeSelf == true)
			{
				if (Input.GetAxis ("Fire1_P1") > 0 && Animation2.GetCurrentAnimatorStateInfo (0).IsName ("New State"))
				{
					Debug.Log ("SwingP1");
					Swing.Play ();
					Animation2.SetTrigger ("ButtonPress");
				}
			}

			if (player1Health == 3) 
			{
				PH4.gameObject.SetActive (true);
				PH3.gameObject.SetActive (false);
				PH2.gameObject.SetActive (false);
				PH11.gameObject.SetActive (false);
				PH5.gameObject.SetActive (false);
				respawn1 = false;
			}
			else if(player1Health == 2)
			{
				PH4.gameObject.SetActive (false);
				PH3.gameObject.SetActive (true);
				PH2.gameObject.SetActive (false);
				PH11.gameObject.SetActive (false);
				respawn2 = false;

				if (respawn1 == false) 
				{
					Respawn ();
					respawn1 = true;
				}
			}
			else if(player1Health == 1)
			{
				PH4.gameObject.SetActive (false);
				PH3.gameObject.SetActive (false);
				PH2.gameObject.SetActive (true);
				PH11.gameObject.SetActive (false);
				if (respawn2 == false) 
				{
					Respawn ();
					respawn2 = true;
				}
			}
		}

		else if (player2) 
		{
			if (Input.GetAxis ("Horizontal_P2") > 0) 
			{
				gameObject.transform.position += transform.right * Time.deltaTime * speed;
				if (facingright != true)
				{
					//SR.flipX = false;
					transform.localScale += new Vector3 (+flipNumber,0,0);
					facingright = true;
				}
			}

			if (Input.GetAxis ("Horizontal_P2") < 0) {
				gameObject.transform.position += -transform.right * Time.deltaTime * speed;
				if (facingright == true) 
				{
					//SR.flipX = true;
					transform.localScale += new Vector3 (-flipNumber,0,0);
					facingright = false;
				}
			}
			if (Input.GetAxis ("Jump_P2") > 0 && GetComponent<Rigidbody2D> ().velocity.y == 0) 
			{
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
			} 

			if (Sword.activeSelf == true)
			{
				if (Input.GetAxis ("Fire1_P2") > 0 && Animation1.GetCurrentAnimatorStateInfo (0).IsName ("New State"))
				{
					Debug.Log ("SwingP2");
					Swing.Play ();
					Animation1.SetTrigger ("ButtonPress");
				}
			}
			else if (MegaSword.activeSelf == true)
			{
				if (Input.GetAxis ("Fire1_P2") > 0 && Animation2.GetCurrentAnimatorStateInfo (0).IsName ("New State"))
				{
					Debug.Log ("SwingP2");
					Swing.Play ();
					Animation2.SetTrigger ("ButtonPress");
				}
			}

			if (player2Health == 3) 
			{
				PH4.gameObject.SetActive (true);
				PH3.gameObject.SetActive (false);
				PH2.gameObject.SetActive (false);
				PH21.gameObject.SetActive (false);
				PH5.gameObject.SetActive (false);
				respawn3 = false;
			}
			else if(player2Health == 2)
			{
				PH4.gameObject.SetActive (false);
				PH3.gameObject.SetActive (true);
				PH2.gameObject.SetActive (false);
				PH21.gameObject.SetActive (false);
				respawn4 = false;
				if (respawn3 == false) 
				{
					Respawn ();
					respawn3 = true;
				}
			}
			else if(player2Health == 1)
			{
				PH4.gameObject.SetActive (false);
				PH3.gameObject.SetActive (false);
				PH2.gameObject.SetActive (true);
				PH21.gameObject.SetActive (false);
				if (respawn4 == false) 
				{
					Respawn ();
					respawn4 = true;
				}
			}

				
				
		}

		else if (player3) 
		{
			if (Input.GetAxis ("Horizontal_P3") > 0) 
			{
				gameObject.transform.position += transform.right * Time.deltaTime * speed;
				if (facingright != true)
				{
					//SR.flipX = false;
					transform.localScale += new Vector3 (+flipNumber,0,0);
					facingright = true;
				}
			}

			if (Input.GetAxis ("Horizontal_P3") < 0) {
				gameObject.transform.position += -transform.right * Time.deltaTime * speed;
				if (facingright == true) 
				{
					//SR.flipX = true;
					transform.localScale += new Vector3 (-flipNumber,0,0);
					facingright = false;
				}
			}
			if (Input.GetAxis ("Jump_P3") > 0 && GetComponent<Rigidbody2D> ().velocity.y == 0) 
			{
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
			} 

			if (Sword.activeSelf == true)
			{
				if (Input.GetAxis ("Fire_P3") > 0 && Animation1.GetCurrentAnimatorStateInfo (0).IsName ("New State"))
				{
					Debug.Log ("SwingP3");
					Swing.Play ();
					Animation1.SetTrigger ("ButtonPress");
				}
			}
			else if (MegaSword.activeSelf == true)
			{
				if (Input.GetAxis ("Fire_P3") > 0 && Animation2.GetCurrentAnimatorStateInfo (0).IsName ("New State"))
				{
					Debug.Log ("SwingP3");
					Swing.Play ();
					Animation2.SetTrigger ("ButtonPress");
				}
			}

			if (player3Health == 3) 
			{
				PH4.gameObject.SetActive (true);
				PH3.gameObject.SetActive (false);
				PH2.gameObject.SetActive (false);
				PH31.gameObject.SetActive (false);
				PH5.gameObject.SetActive (false);
				respawn3 = false;
			}
			else if(player3Health == 2)
			{
				PH4.gameObject.SetActive (false);
				PH3.gameObject.SetActive (true);
				PH2.gameObject.SetActive (false);
				PH31.gameObject.SetActive (false);
				respawn4 = false;
				if (respawn3 == false) 
				{
					Respawn ();
					respawn3 = true;
				}
			}
			else if(player3Health == 1)
			{
				PH4.gameObject.SetActive (false);
				PH3.gameObject.SetActive (false);
				PH2.gameObject.SetActive (true);
				PH31.gameObject.SetActive (false);
				if (respawn4 == false) 
				{
					Respawn ();
					respawn4 = true;
				}
			}



		}

		else if (player4) 
		{
			if (Input.GetAxis ("Horizontal_P4") > 0) 
			{
				gameObject.transform.position += transform.right * Time.deltaTime * speed;
				if (facingright != true)
				{
					//SR.flipX = false;
					transform.localScale += new Vector3 (+flipNumber,0,0);
					facingright = true;
				}
			}

			if (Input.GetAxis ("Horizontal_P4") < 0) {
				gameObject.transform.position += -transform.right * Time.deltaTime * speed;
				if (facingright == true) 
				{
					//SR.flipX = true;
					transform.localScale += new Vector3 (-flipNumber,0,0);
					facingright = false;
				}
			}
			if (Input.GetAxis ("Jump_P4") > 0 && GetComponent<Rigidbody2D> ().velocity.y == 0) 
			{
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
			} 

			if (Sword.activeSelf == true)
			{
				if (Input.GetAxis ("Fire_P4") > 0 && Animation1.GetCurrentAnimatorStateInfo (0).IsName ("New State"))
				{
					Debug.Log ("SwingP4");
					Swing.Play ();
					Animation1.SetTrigger ("ButtonPress");
				}
			}
			else if (MegaSword.activeSelf == true)
			{
				if (Input.GetAxis ("Fire_P4") > 0 && Animation2.GetCurrentAnimatorStateInfo (0).IsName ("New State"))
				{
					Debug.Log ("SwingP4");
					Swing.Play ();
					Animation2.SetTrigger ("ButtonPress");
				}
			}

			if (player4Health == 3) 
			{
				PH4.gameObject.SetActive (true);
				PH3.gameObject.SetActive (false);
				PH2.gameObject.SetActive (false);
				PH41.gameObject.SetActive (false);
				PH5.gameObject.SetActive (false);
				respawn3 = false;
			}
			else if(player4Health == 2)
			{
				PH4.gameObject.SetActive (false);
				PH3.gameObject.SetActive (true);
				PH2.gameObject.SetActive (false);
				PH41.gameObject.SetActive (false);
				respawn4 = false;
				if (respawn3 == false) 
				{
					Respawn ();
					respawn3 = true;
				}
			}
			else if(player4Health == 1)
			{
				PH4.gameObject.SetActive (false);
				PH3.gameObject.SetActive (false);
				PH2.gameObject.SetActive (true);
				PH41.gameObject.SetActive (false);
				if (respawn4 == false) 
				{
					Respawn ();
					respawn4 = true;
				}
			}



		}

		if(player1Health == 0 && P1Attacked == true)
		{
			PH11.gameObject.SetActive (true);
			player1dead = true;

			if(player2Health >= 1 && player3Health >= 1 && player4Health >= 1)
			{
				if (added2 == false)
				{
					PlayerPrefs.SetInt ("Player1LoseStreak", PlayerPrefs.GetInt ("Player1LoseStreak") + 1);
					PlayerPrefs.SetInt ("Player2LoseStreak", 0);
					PlayerPrefs.SetInt ("Player3LoseStreak", 0);
					PlayerPrefs.SetInt ("Player4LoseStreak", 0);
					added2 = true;
				}
			}

			P1.gameObject.SetActive (false);
		}

		if(player2Health == 0 && P2Attacked == true)
		{
			PH21.gameObject.SetActive (true);
			player2dead = true;

			if(player1Health >= 1 && player3Health >= 1 && player4Health >= 1)
			{
				if (added2 == false)
				{
					PlayerPrefs.SetInt ("Player2LoseStreak", PlayerPrefs.GetInt ("Player2LoseStreak") + 1);
					PlayerPrefs.SetInt ("Player1LoseStreak", 0);
					PlayerPrefs.SetInt ("Player3LoseStreak", 0);
					PlayerPrefs.SetInt ("Player4LoseStreak", 0);
					added2 = true;
				}
			}

			P2.gameObject.SetActive (false);
		}

		if(player3Health == 0 && P3Attacked == true)
		{
			PH31.gameObject.SetActive (true);
			player3dead = true;

			if(player2Health >= 1 && player1Health >= 1 && player4Health >= 1)
			{
				if (added2 == false)
				{
					PlayerPrefs.SetInt ("Player3LoseStreak", PlayerPrefs.GetInt ("Player3LoseStreak") + 1);
					PlayerPrefs.SetInt ("Player2LoseStreak", 0);
					PlayerPrefs.SetInt ("Player1LoseStreak", 0);
					PlayerPrefs.SetInt ("Player4LoseStreak", 0);
					added2 = true;
				}
			}

			P3.gameObject.SetActive (false);
		}

		if(player4Health == 0 && P4Attacked == true)
		{
			PH41.gameObject.SetActive (true);
			player4dead = true;

			if(player2Health >= 1 && player3Health >= 1 && player1Health >= 1)
			{
				if (added2 == false)
				{
					PlayerPrefs.SetInt ("Player4LoseStreak", PlayerPrefs.GetInt ("Player4LoseStreak") + 1);
					PlayerPrefs.SetInt ("Player2LoseStreak", 0);
					PlayerPrefs.SetInt ("Player3LoseStreak", 0);
					PlayerPrefs.SetInt ("Player1LoseStreak", 0);
					added2 = true;
				}
			}

			P4.gameObject.SetActive (false);
		}
	}
}
