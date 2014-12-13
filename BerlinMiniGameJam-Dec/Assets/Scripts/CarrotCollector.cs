using UnityEngine;
using System.Collections;

public class CarrotCollector : MonoBehaviour 
{
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

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Carrot(Clone)") 
		{
			Destroy(col.gameObject);

			if (carrotCounter < requiredCarrotsForAttacking)
			{
				carrotCounter++;

			}

			if (carrotCounter == 4){
				angryMode.activateAngryMode();
			}

			Debug.Log("carrot counter: " + carrotCounter);
		}
	}

	public void resetCounter()
	{
		carrotCounter = 0;
	}
}
