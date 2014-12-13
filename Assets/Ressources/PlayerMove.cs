using UnityEngine;
using System.Collections;

public class Player_Mover : MonoBehaviour {

	public GameObject player;
	//player
	public float speed; //declare the player move speed in Unity inspector
	public Transform groundedEnd; //declares the empty game object in Unity acting as a collider set to the position of the player

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
				Movement (); //call the movement function below
				isGrounded = Physics2D.Linecast (this.transform.position, groundedEnd.position, 1 << LayerMask.NameToLayer ("Ground")); 
		}
	void Movement()
		{
			//Move Right
			if (Input.GetKey (KeyCode.LeftArrow)) 
			{
				transform.Translate (Vector2.left * speed * Time.deltaTime);
				transform.eulerAngles = new Vector2(0,0); 
			}
			//Move Left
			if (Input.GetKey (KeyCode.RightArrow)) 
			{
				transform.Translate (Vector2.right * speed * Time.deltaTime);
				transform.eulerAngles = new Vector2(0,180); //flip the character on its x axis
			}			
		}
}
