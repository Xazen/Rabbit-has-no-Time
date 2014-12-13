using UnityEngine;
using System.Collections;

public class CarrotCollector : MonoBehaviour 
{
	[SerializeField]
	float carrotTimer = 4;
	[SerializeField]
	int requiredCarrotsForAttacking = 4;

	private AngryMode angryMode;
	private int carrotCounter = 0;

	void Start()
	{
		angryMode = this.GetComponent<AngryMode> ();
	}

	void Update()
	{
		if (angryMode) 
		{

		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Carrot(Clone)") 
		{
			carrotCounter++;
			Debug.Log("carrot counter: " + carrotCounter);
			Destroy(col.gameObject);

			if (carrotCounter == requiredCarrotsForAttacking)
			{
				angryMode.activateAngryMode();
			}
		}
	}
}
