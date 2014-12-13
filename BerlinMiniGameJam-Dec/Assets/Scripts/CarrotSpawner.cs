using UnityEngine;
using System.Collections;

public class CarrotSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject carrot;
	[SerializeField]
	private float spawnFrequency = 3;
	// Use this for initialization

	private float spawnTimer = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer += Time.deltaTime;
		
		if (spawnTimer >= spawnFrequency) 
		{
			spawnTimer = 0;
			GameObject spawningCarrot = (GameObject)GameObject.Instantiate(carrot);
			float randomX = Random.Range(0, 19.2);
			spawningCarrot.transform.localPosition = new Vector3(randomX, 10.8);
		}

	}
}
