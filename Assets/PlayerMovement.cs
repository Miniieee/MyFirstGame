using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private Vector3 moveSpeed;
    [SerializeField] private Vector3 jump;
    private PlayerInput inputActions;
    private Rigidbody rb;
    private float direction;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputActions = new PlayerInput();
    }

    private void Start() 
    {
        inputActions.Player.Jump.performed += ctx => Jump();
    }

    void Update() 
    {
        direction = inputActions.Player.Movement.ReadValue<float>();
        Debug.Log(direction);
    }

    private void Jump()
    {
        rb.AddForce(jump);
    }

    private void FixedUpdate() 
    {
        rb.AddForce(direction * moveSpeed * Time.deltaTime);
    }

    private void OnEnable() {
        inputActions.Enable();
        inputActions.Player.Jump.Enable();
    }

    private void OnDisable() {
        inputActions.Disable();
        inputActions.Player.Jump.Disable();
    }
    
    


    /*
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
    }*/
}
