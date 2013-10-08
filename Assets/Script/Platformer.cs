using UnityEngine;
using System.Collections;

public class Platformer : MonoBehaviour {

	public float speed = 2;
	public float jumppower = 50;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)){
			rigidbody.AddForce (Vector3.left *speed);
		}
		
		if (Input.GetKey (KeyCode.RightArrow)){
			rigidbody.AddForce (Vector3.right * speed);
		}
		
		if (Input.GetKeyDown (KeyCode.Space)){
			if (Physics.Raycast(transform.position, transform.up * -1f, 0.5f)){
			rigidbody.AddForce (Vector3.up * jumppower);
			}
		}
	
	}
}
