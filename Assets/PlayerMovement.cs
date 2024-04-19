using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private Vector3 moveSpeed;
    private Rigidbody rb;
    private bool isRightPressed;
    private bool isLeftPressed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
           isRightPressed = true;    
        }
        else
        {
            isRightPressed = false;
        }

        if(Input.GetKey(KeyCode.A))
        {
            isLeftPressed = true;
        }
        else
        {
            isLeftPressed = false;  
        }
       
    }

    private void FixedUpdate()
    {
        if(isRightPressed)
        {
            rb.AddForce(moveSpeed * Time.deltaTime);
        }

        if(isLeftPressed)
        {
            rb.AddForce(-moveSpeed * Time.deltaTime);
        }
    }
}
