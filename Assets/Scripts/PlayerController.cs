using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public CharacterController controller;
	public Animator anim;
	public float speed = 5;
	public float jumpSpeed = 10;
	public float gravity = 10;
	public GameObject playerObject;
	
	private Vector3 moveDirection;
	private Vector3 tempLook;

	// Use this for initialization
	void Start () {

		controller = this.GetComponent<CharacterController> ();
		anim = playerObject.GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if(controller.isGrounded)
		{
			moveDirection.x = Input.GetAxis("L_XAxis_1") * speed;
			moveDirection.z = Input.GetAxis("L_YAxis_1") * speed;
			moveDirection.y = 0f;
			moveDirection = transform.TransformDirection (moveDirection);
			if(moveDirection != Vector3.zero)
			{
				playerObject.transform.forward = Vector3.Normalize(moveDirection * Time.deltaTime * 5);
			}

			if(Input.GetButtonDown("A_1"))
			{
				moveDirection.y = jumpSpeed;
				anim.SetTrigger("Jump");
			}
		}
		moveDirection.y -= gravity * Time.deltaTime;

		controller.Move (moveDirection * Time.deltaTime);

		anim.SetFloat ("Speed", controller.velocity.magnitude);
	
	}
}
