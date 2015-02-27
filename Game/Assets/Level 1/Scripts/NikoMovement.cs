using UnityEngine;
using System.Collections;

public class NikoMovement : MonoBehaviour {

		Vector3 velocity = Vector3.zero;
		public float fireSpeed = 100f;
		public float forwardSpeed = 1f;
		
		bool didFlap = false;

		Animator animator;
	if()
	//se neki
	//se neki druzga
	//test
	//neki
	//hehe
		bool dead = false;
		float deathCooldown;

		// Use this for initialization
		void Start () {
		animator = transform.GetComponentInChildren<Animator> ();



		if (animator == null) {
						Debug.LogError ("Didn't find animator!");
				}
			
		}
		
		// Do Graphich & Inpud updates here
		void Update() {
				if (dead) {
						deathCooldown -= Time.deltaTime;

						if (deathCooldown <= 0) {
								if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
										Application.LoadLevel (Application.loadedLevel);
								}
						}
				}
		else {
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
				didFlap = true;
						}
			
				}
		}
		
				
		// Do physics engine updates here
		void FixedUpdate () {

		if(dead)
			return;

		rigidbody2D.AddForce (Vector2.right * forwardSpeed);

		if(didFlap) {
			rigidbody2D.AddForce (Vector2.up * fireSpeed);
			animator.SetTrigger("DoFire");


			didFlap = false;
				

		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		animator.SetTrigger("Death");
		dead = true;
		deathCooldown = 0.5f;

		if (dead) {

				}
	}
}

	
	
	

	
	
	

