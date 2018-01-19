using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobbing : MonoBehaviour {
	
	
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(new Vector3(15, 30, 25) * Time.deltaTime);
		//if
		//transform.Translate(new Vector3()
	}
}
