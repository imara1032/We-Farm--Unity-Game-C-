
using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {


	public float speed = 6f;
	private Vector3 movement;
	Animator anim;
	private Rigidbody rb;
	int floorMask;
	float camRayLength=100f;

	void Awake(){
		floorMask= LayerMask.GetMask("Floor");
		anim= GetComponent<Animator>();
		rb= GetComponent<Rigidbody>();
	}


	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		move (h,v);
		Animating (h, v);
	}

	void move(float h, float v){
		movement.Set (h,0f,v);
		movement = movement.normalized * speed * Time.deltaTime;
		rb.MovePosition (transform.position+ movement);

	}
	void Animating(float h, float v){
		bool walking = h != 0f || v != 0f;
			anim.SetBool("IsWalking",walking);
    

       // bool tumble = h == 0f || v == 0f;
          //   anim.SetBool("IsTumble", tumble);


	}

}
