using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	Vector3 movement;
	
	Rigidbody player;
	
	Vector3 Force;
	
	public float speed = 1000f;
	public float speedLimit = 5f;
	
    // Start is called before the first frame update
    void Start()
    {
		//Physics.gravity = new Vector3(0, -9.8F, 0);
		
		GameObject Camera = GameObject.Find("Main Camera");
		GameObject JP = GameObject.Find("JP");
        player = JP.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		Movement();
    }
	
	void Movement()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		float jump = Input.GetAxisRaw("Jump");
		
		Vector3 Direction;
		Direction = player.transform.forward * vertical + player.transform.right * horizontal + player.transform.up * jump; 
		// + player.transform.up * gravity
		
		//Force = new Vector3(horizontal, gravity, vertical);
		//Force = Vector3.Normalize(Force);
		Direction = Vector3.Normalize(Direction);
		
		
		player.AddForce(Direction * speed);
		
		//---------------------------------
		//-----LIMITADOR DE VELOCIDAD------
		//---------------------------------
		
		Vector3 velocity = new Vector3(player.velocity.x, 0f, player.velocity.z);
		
		if(velocity.magnitude > speedLimit)
		{
			Vector3 velocityLimitator = velocity.normalized * speedLimit;
			player.velocity = new Vector3(velocityLimitator.x, player.velocity.y, velocityLimitator.z);
		}
		
	}
}
