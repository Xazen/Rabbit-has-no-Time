using UnityEngine;
using System.Collections;

public class AngryMode : MonoBehaviour {

	private bool activated = false;

	private float punchFrequency = 2;
	private float punchTimer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		punchTimer += Time.deltaTime;

		if (activated && punchTimer >= 2 && Input.GetButton ("Fire1")) 
		{
			punch ();
		}
	}

	void punch ()
	{
		punchTimer = 0;
		Debug.Log ("punch");
	}

	public void activateAngryMode()
	{
		Debug.Log ("angry");
		activated = true;
	}
}
