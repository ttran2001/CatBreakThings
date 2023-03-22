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
        // Move left and right using arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal * speed, rb.velocity.y, 0.0f);
        rb.velocity = movement;

        // Jump using spacebar
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            isOnGround = false; 

        }
    }

    private void OnCollisionEnter(Collision collision){
        if(isOnGround== false){
            isOnGround = true;
        }
    }
}
