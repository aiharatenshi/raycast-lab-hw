using UnityEngine;
using System.Collections;

public class NpcBot : MonoBehaviour {
	int speed = 5;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void Update () {
		
		
		//Ray ray = Camera.main.ScreenPointToRay (
		
		//RaycastHit rayHit = newRaycastHit();
		
		if (Physics.Raycast (transform.position, transform.forward, 20f)){
			int randomNumber = Random.Range (0, 10);
			if (randomNumber < 5) {
				transform.Rotate (0f, 90f, 0f);
			}
			else {
				transform.Rotate (0f, -90f, 0f);
			}
		}
	}
	
	void FixedUpdate(){
			rigidbody.AddForce (transform.forward * speed);
		}
			
			
		
}
