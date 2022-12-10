using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
	public float walkSpeed;
	
	public float moveHorizontal;
	public Vector2 moveHorizontalVector;
	
	public float moveVertical;
	public Vector2 moveVerticalVector;

	Vector3 moveInput = Vector3.zero;
	CharacterController characterController;
	
	private void Awake()
	{
		characterController = GetComponent<CharacterController>();
	}

	private void Update()
	{
		Move();
	}
	
	private void Move()
	{
        moveHorizontal = Input.GetAxisRaw("Horizontal");
		moveVertical = Input.GetAxisRaw("Vertical");
		
		moveHorizontalVector = new Vector3(moveHorizontal * walkSpeed, 0f);
	
	}
}
