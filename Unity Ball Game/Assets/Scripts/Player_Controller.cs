using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour {
	
	public float speed;
	private Rigidbody sphereRB;
	public float jumpForce;
	private bool isGrounded;
	private int score;
	public Text scoreText;
	public Text winText;
	
	void Start()
	{
		sphereRB = GetComponent<Rigidbody>();
		score = 0;
		setScoreText();
		winText.text = "";
	}
	
	void FixedUpdate()
    {
		//Horizontal movement
        float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		
		sphereRB.AddForce(movement * speed);
		
		//Jump 
		isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.5f);
		
		if(isGrounded && Input.GetKey(KeyCode.Space))
		{
			sphereRB.AddForce(0, jumpForce, 0);
		}
    }
	
	void OnTriggerEnter(Collider other) 
	{
		//Destroy(other.gameObject);
		
		if(other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			score++;
			setScoreText();
		}
	}
	
	void setScoreText()
	{
		scoreText.text = "Score: " + score.ToString();
		if(score >= 12)
		{
			winText.text = "You win!";
		}
	}
}
