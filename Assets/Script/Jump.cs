using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	//Maximum speed of the player (if they have an input button all the way down)
	public float maxSpeed = 10f;

	//Amount of force to apply when jumping
	public float jumpForce = 300f;

	//Reference to Rigidbody2D, so we don't need to try and call GetComponent every frame and every physics timestep
	Rigidbody2D myRigidbody;

	//Whether we're on the ground or not
	bool grounded = false;

	//The location where to check if the player has hit the ground (much like the canon, can not use the transform of the player)
	public Transform groundCheck;

	//How big the groundCheck should be
	float groundRadius = 0.2f;

	//Determining what things are the ground or not (for example, the player is not the ground
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (grounded && Input.GetButtonDown ("Jump")) {
			grounded = false;
			myRigidbody.AddForce (new Vector2 (0, jumpForce));
		}
	}

	// Update is called once per *physics timestep*
	void FixedUpdate() {

		//Determining if the ground check spot has hit anywhere (on the ground)
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
	}

	//Called when we hit powerups!
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Enemy") {
			//Destroy(other.gameObject);
			//DIE
			Debug.Log("Player Should Die!");
		}
	}
}
