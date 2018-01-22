using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobbing : MonoBehaviour {
	
	private int direction = 1;
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(new Vector3(15, 30, 25) * Time.deltaTime);

		transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y + Random.Range(0.001f, 0.1f)*direction, transform.localPosition.z);
		if(transform.localPosition.y > 2)
		{
			direction = -1;
		}
		else if(transform.localPosition.y <= 0.5f)
		{
			direction = 1;
		}
	}
}
