using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideForce = 700f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        // add force to move forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(- sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
