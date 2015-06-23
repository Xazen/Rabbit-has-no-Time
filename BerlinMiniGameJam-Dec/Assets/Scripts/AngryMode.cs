using UnityEngine;
using System.Collections;

public class AngryMode : MonoBehaviour {

	[SerializeField]
	private int attackPower = 1;
	[SerializeField]
	private GameObject wolf;

	public bool activated = false;
	private float punchFrequency = 2;
	private float punchTimer = 0;
	private float angryFrequency = 4;
	private float angryTimer = 0;
	private RabbitHealth wolfHealth;
	private bool isCollidingWithWolf = false;

	[SerializeField]
	AudioClip punchSound;

	CarrotCollector carrotCollector;
	CarrotSpawner carrotSpawner;

	// Use this for initialization
	void Start () {
		carrotCollector = this.GetComponent<CarrotCollector> ();
		carrotSpawner = GameObject.FindGameObjectWithTag ("CarrotSpawner").GetComponent<CarrotSpawner> ();
		wolfHealth = wolf.GetComponent<RabbitHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (activated) 
		{
			angryTimer += Time.deltaTime;
			punchTimer += Time.deltaTime;
		}
		if (angryTimer >= angryFrequency) 
		{
			//Debug.Log ("ANGRY MODE OFF");
			deactivateAngryMode();

		}
		if (activated && punchTimer >= punchFrequency && Input.GetButton ("Fire1")) 
		{
			punch ();
		}
	}

	void punch ()
	{
		punchTimer = 0;
		//Debug.Log ("punch");
		if (isCollidingWithWolf) 
		{
			wolfHealth.hurt(attackPower);
			this.GetComponent<AudioSource>().PlayOneShot(this.punchSound);
		}
	}

	public void activateAngryMode()
	{
		Debug.Log ("ANGRY MODE ON");
		activated = true;
		carrotSpawner.deactivateSpawner ();
		this.transform.localScale = new Vector3 (0.5f, 0.5f, 1);
	}
	public void deactivateAngryMode()
	{
		Debug.Log ("ANGRY MODE OFF");
		angryTimer = 0;
		activated = false;
		carrotCollector.resetCounter ();
		carrotSpawner.activateSpawner ();
		this.transform.localScale = new Vector3 (0.35f, 0.35f, 1);
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "Wolf") {
			isCollidingWithWolf = true;
				}

	}

	void OnTriggerExit2D(Collider2D collider)
	{
		if (collider.gameObject.name == "Wolf") {
			isCollidingWithWolf = false;
				}

	}
}
