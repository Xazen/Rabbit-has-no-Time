using UnityEngine;
using System.Collections;

public class WolfPunch : MonoBehaviour
{
	public GameObject punch;
	public Transform punchSpawn;
	public float punchRate;
	public float delay;

	void Start ()
	{
		InvokeRepeating ("Punch", delay, punchRate);
	}

	void Punch ()
	{
		Instantiate(punch, punchSpawn.position, punchSpawn.rotation);
		audio.Play();
	}
}
