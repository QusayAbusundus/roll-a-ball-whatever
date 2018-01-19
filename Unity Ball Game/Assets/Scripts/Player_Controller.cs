using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {
	
	public float speed;
	private Rigidbody sphereRB;
	
	void Start()
	{
		sphereRB = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		
		sphereRB.AddForce(movement * speed);
    }
}
