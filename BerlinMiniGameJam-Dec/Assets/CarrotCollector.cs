using UnityEngine;
using System.Collections;

public class CarrotCollector : MonoBehaviour 
{

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Carrot(Clone)") 
		{
			Destroy(col.gameObject);
		}
	}
}
