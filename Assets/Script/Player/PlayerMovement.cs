using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	public Transform camera;
	Vector3 movement;
	
	Rigidbody player;
	
	Vector3 Force;
	
	public float speed = 1f;
	
    // Start is called before the first frame update
    void Start()
    {
		GameObject JP = GameObject.Find("JP");
        player = JP.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		float horizontal = Input.GetAxisRaw("Horizontal");
		float moveHorizontal = horizontal * speed;

		
		float vertical = Input.GetAxisRaw("Vertical");
		float moveVertical = vertical * speed;
		
		Force = new Vector3(horizontal, 0, 0);
		
		player.AddForce(Force);
		
		
		
		
//		rb.rotation = Quaternion.Euler(camera.rotating.localEulerAngles.x, camera.rotating.localEulerAngles.y, 0f);
		
//		Vector3 movement = transform.right * horizontal + transform.forward * vertical;
		
//		rb.position = new Vector3(transform.forward * vertical, transform.forward * vertical, 0f);
    }
}
