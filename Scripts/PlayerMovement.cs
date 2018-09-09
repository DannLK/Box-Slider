using UnityEngine;

public class PlayerMovement : MonoBehaviour {

public Rigidbody rb;

public float forwardForce = 1000f;
public float sidewaysForce = 600f;
public bool moveRight = false;
public bool moveLeft = false;
	

	void FixedUpdate () {
		rb.AddForce(0, 0, forwardForce* Time.deltaTime);

		if(moveRight == true){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
			moveRight = false;
		}

		if(moveLeft == true){
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
			moveLeft = false;
		}
	}

// Update is called once per frame
	void Update(){
			if(Input.GetKey("d")){
			moveRight = true;
		}

			if(Input.GetKey("a")){
			 moveLeft = true;
		}

        if (rb.position.y < -2f)
            FindObjectOfType<GameManager>().EndGame();
    }
}
