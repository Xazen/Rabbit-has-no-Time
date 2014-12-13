using UnityEngine;
using System.Collections;

public class ExpireTimer : MonoBehaviour {

	[SerializeField]
	private float expireTime = 5;

	private float expiredTime = 0;

	// Update is called once per frame
	void Update () {
		expiredTime += Time.deltaTime;

		if (expiredTime >= expireTime) 
		{
			Destroy (this.gameObject);
		}
	}
}
