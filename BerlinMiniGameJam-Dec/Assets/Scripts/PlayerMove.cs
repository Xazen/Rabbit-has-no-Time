using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	[SerializeField]
	private float speed = 10;

	public bool canUseHole = true;

	[SerializeField]
	public float holeUseFrequency = 0.2f;
	public float useHoleTimer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		useHoleTimer += Time.deltaTime;

		if (useHoleTimer >= holeUseFrequency) {
			canUseHole = true;
				}

		float horizontalMovement = Input.GetAxis ("Horizontal");

		this.transform.localPosition = new Vector3 (this.transform.localPosition.x + horizontalMovement * Time.deltaTime * speed, this.transform.localPosition.y);
	}

	public void usedHole()
	{
		canUseHole = false;
		useHoleTimer = 0;
	}
}
