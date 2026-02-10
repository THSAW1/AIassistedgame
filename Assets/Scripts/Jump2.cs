using UnityEngine;

public class Jump2 : MonoBehaviour
{
  public float jumpForce = 5f;  
    private Rigidbody rb;  
    private bool isGrounded;  
  
    void Start()  
    {  
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody  
    }  
  
    void Update()  
    {  
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)  
        {  
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Jump up!  
            isGrounded = false; // Prevents double jump  
        }  
    }  
  
    void OnCollisionEnter(Collision collision)  
    {  
        // When hitting something (like the plane), allow jumping again  
        isGrounded = true;  
    }  
}
