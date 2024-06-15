using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables
    public float forceApplied = 20f;
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public Vector3 playerVelocity;

    //Fixed update function
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (rb.velocity.z >= 100)
        {
            playerVelocity = rb.velocity;
            rb.velocity = new Vector3(playerVelocity.x, playerVelocity.y, 100);
        }


        if (Input.GetKey("d") || Input.GetKey("right") || Input.GetKey("a") || Input.GetKey("left"))
        {
            if (Input.GetKey("d") || Input.GetKey("right"))
            {
                rb.AddForce(forceApplied * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey("a") || Input.GetKey("left"))
            {
                rb.AddForce(-forceApplied * Time.deltaTime, 0, 0);
            }
        }
        else{
            if(rb.velocity.x > 0){
                rb.AddForce(-forceApplied * 0.1f * Time.deltaTime, 0, 0);
            }
            if(rb.velocity.x < 0){
                rb.AddForce(forceApplied * 0.1f * Time.deltaTime, 0, 0);
            }
        }

    }
}
