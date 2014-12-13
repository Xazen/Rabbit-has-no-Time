using UnityEngine;
using System.Collections;

public class hole : MonoBehaviour {

	[SerializeField]
	private GameObject player;
	[SerializeField]
	private GameObject otherHole1;
	[SerializeField]
	private GameObject otherHole2;

	private bool collide = false;

	PlayerMove playerMove;
	[SerializeField]
	AudioClip jumpInHole;

	void Start()
	{
		playerMove = player.GetComponent<PlayerMove> ();
	}

	void Update()
	{
		float getaxis = Input.GetAxis ("Vertical");

		if (Input.GetAxis ("Vertical") < 0 && collide && playerMove.canUseHole) 
		{
			float random = Random.Range(0, 1);
			playerMove.usedHole();

			float newX = 0.0f;
			if (random > 0.5)
			{
				newX = otherHole1.transform.position.x;
			} else {
				newX = otherHole2.transform.position.x;
			}
			this.audio.PlayOneShot(this.jumpInHole);
			player.transform.localPosition = new Vector3(newX, player.transform.localPosition.y, player.transform.localPosition.z);
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "Rabbit") {
			collide = true;
				}
	}

	void OnTriggerExit2D(Collider2D collider)
	{
		if (collider.gameObject.name == "Rabbit") {
						collide = false;
				}
	}
}
