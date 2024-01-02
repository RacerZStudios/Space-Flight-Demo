using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightController : MonoBehaviour
{
    [SerializeField] public float thrust;
    [SerializeField] public float speed;
    [SerializeField] public float pitch;
    [SerializeField] public float yaw;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField] private GameObject cockPitCamera;
    private int i; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && i <= 0)
        {
            i += 1; 
            cockPitCamera.SetActive(true);
            i = 1; 
        }
        else if(Input.GetKeyDown(KeyCode.R) && i >= 1)
        {
            i -= 1; 
            cockPitCamera.SetActive(false);
            i = 0; 
        }
    }

    private void FixedUpdate()
    {
        float pitch = Input.GetAxisRaw("Vertical");
        float yaw = Input.GetAxisRaw("Horizontal");

        rb.AddRelativeForce(0, 0, thrust * speed * Time.deltaTime);
        rb.AddRelativeTorque(pitch * speed * Time.deltaTime, yaw * speed * Time.deltaTime, -yaw * speed * 2 * Time.deltaTime); 

        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.left * thrust * 50 * Time.deltaTime); 
        }
        else
        {
            rb.velocity = Vector3.zero; 
        }
    }
}
