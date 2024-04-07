using UnityEngine;

public class Example : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 direction;




    void Start()
    {
        Debug.Log("My Second Line of Code");
    }

    



    void Update()
    {
        rb.AddForce(direction);
    }
}
