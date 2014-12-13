using UnityEngine;
using System.Collections;

public class WolfMove : MonoBehaviour {

	[SerializeField]
	private float speed = 3;
	[SerializeField]
	private float horizontalMovementR = 1;
	[SerializeField]
	private float horizontalMovementL = -1;
	[SerializeField]
	private GameObject player;
	[SerializeField]
	private int attackPower = 1;
	[SerializeField]
	private float attackFrequency = 2.0f;

	private float attackTimer = 0.0f;
	private RabbitHealth rabbitHealth;

	void Start()
	{
		rabbitHealth = player.GetComponent<RabbitHealth> ();
	}

	// Update is called once per frame
	void Update () 
	{
		attackTimer += Time.deltaTime;

		if (player != null) 
		{
			if (player.transform.localPosition.x < this.transform.localPosition.x) 
			{
				moveLeft ();
			} else {
				moveRight();
			}
		}
	}

	void moveLeft() {
		//MakeAnimationLeft
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x + horizontalMovementL * Time.deltaTime * speed, this.transform.localPosition.y);
	}

	void moveRight() {
		//MakeAnimationRight
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x + horizontalMovementR * Time.deltaTime * speed, this.transform.localPosition.y);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("wolf collision" + col.gameObject.name);
		if (col.gameObject.name == "Rabbit") 
		{
			if (attackTimer >= attackFrequency)
			{
				attack();
			}
		}
	}

	void attack()
	{
		attackTimer = 0;
		rabbitHealth.hurt (attackPower);
		player.transform.localPosition = new Vector3 (player.transform.localPosition.x, player.transform.localPosition.y, player.transform.localPosition.z);
		Debug.Log ("Wolf attack");
	}
}