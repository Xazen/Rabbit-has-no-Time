using UnityEngine;
using System.Collections;

public class WolfMove : MonoBehaviour {

	[SerializeField]
	private float speed = 3;
	[SerializeField]
	private float horizontalMovementR = 5;
	[SerializeField]
	private float horizontalMovementL = -5;
	private GameObject player;
	private GameObject enemy;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		enemy = GameObject.FindGameObjectWithTag ("Enemy");
	}
	
	// Update is called once per frame
	void Update () {

	}
	void moveLeft() {
		//MakeAnimationLeft
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x + horizontalMovementL * Time.deltaTime * speed, this.transform.localPosition.y);
	}

	void moveRight() {
		//MakeAnimationRight
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x + horizontalMovementR * Time.deltaTime * speed, this.transform.localPosition.y);
	}
}