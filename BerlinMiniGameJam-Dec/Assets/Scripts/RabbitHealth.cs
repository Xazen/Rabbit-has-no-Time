using UnityEngine;
using System.Collections;

public class RabbitHealth : MonoBehaviour {

	[SerializeField]
	private int health = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void hurt(int damage)
	{
		Debug.Log ("Hurt object:" + this.gameObject.name);
		health-=damage;
		if (health == 0) 
		{
			die();
		}
	}

	public void die()
	{
		Debug.Log ("Die:" + this.gameObject.name);
		Destroy (this.gameObject);
	}
}
