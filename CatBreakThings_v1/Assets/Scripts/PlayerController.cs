using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpHeight = 7.0f; // increased from 2.0f
    private Rigidbody rb;
    public bool isOnGround = true; 


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal * speed, rb.velocity.y, 0.0f);
        rb.velocity = movement;

        // Jump the Cat object if user hits the space bar
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            isOnGround = false; 

        }
    }

    private void OnCollisionEnter(Collision collision){
        if(isOnGround== false){
            isOnGround = true; // If the cat is on the ground after jumping, it resets, letting the cat jump again
        }
    }
}
