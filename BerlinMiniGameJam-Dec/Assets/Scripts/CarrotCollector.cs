using UnityEngine;
using System.Collections;

public class CarrotCollector : MonoBehaviour 
{
	[SerializeField]
	float carrotTimer = 4;
	float requiredCarrotsForAttacking = 4;
	
	private int carrotCounter = 0;

	void Update()
	{
		if (carrotCounter > requiredCarrotsForAttacking) 
		{
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Carrot(Clone)") 
		{
			Destroy(col.gameObject);
			carrotCounter++;
		}
	}
}
