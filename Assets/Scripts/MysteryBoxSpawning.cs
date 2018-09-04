using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBoxSpawning : MonoBehaviour {

	public float waitingTime,range1,range2;
	private int SpawnPoint, boxChoice, randomNo;
	public GameObject[] SpawnArray;
	public GameObject[] Box;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Spawn ());
	}

	private IEnumerator Spawn ()
	{
		while (true)
		{
			randomNo = Random.Range (1, 5);
			if (randomNo >= 1 && randomNo <= 4)
			{
				boxChoice = 0;
			} 
			else if (randomNo == 5)
			{
				boxChoice = 1;
			}
			waitingTime = Random.Range (range1, range2);
			SpawnPoint = Random.Range (0, SpawnArray.Length);
			yield return new WaitForSecondsRealtime (waitingTime);

			Instantiate (Box[boxChoice], SpawnArray [SpawnPoint].transform.position, transform.rotation);
		}
	}
}
