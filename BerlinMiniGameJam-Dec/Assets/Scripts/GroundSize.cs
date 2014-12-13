using UnityEngine;
using System.Collections;

public class GroundSize : MonoBehaviour {

	[SerializeField]
	public float groundHeight = 1;

	// Update is called once per frame
	void Update () {
		this.transform.localScale = new Vector3(this.transform.localScale.x, groundHeight, this.transform.localScale.z);
	}
}
