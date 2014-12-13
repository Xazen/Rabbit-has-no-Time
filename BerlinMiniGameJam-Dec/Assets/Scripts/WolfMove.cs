using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	[SerializeField]
	private float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalMovement = Input.GetAxis ("Horizontal");

		this.transform.localPosition = new Vector3 (this.transform.localPosition.x + horizontalMovement * Time.deltaTime * speed, this.transform.localPosition.y);
	}
}
