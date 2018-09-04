using UnityEngine;
using System.Collections;

public class Moving1 : MonoBehaviour 
{
	public float movingDistance = 84;

	private void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("SectionTrigger");

		if (other.gameObject.tag == "CameraTrigger") 
		{
			transform.position += new Vector3 (movingDistance , 0f, 0f);
		}
	}
}
