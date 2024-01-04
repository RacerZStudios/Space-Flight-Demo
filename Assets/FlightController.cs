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
    [SerializeField] private AudioSource mainAudioSource;
    [SerializeField] private AudioSource flightAudioSource;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject vCam5;
    [SerializeField] private GameObject vCam6; 
    private int i; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = GetComponent<Camera>(); 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && i <= 0)
        {
            i += 1; 
            cockPitCamera.SetActive(true);
            mainAudioSource.Stop();
            flightAudioSource.Play(); 
            i = 1; 
        }
        else if(Input.GetKeyDown(KeyCode.R) && i >= 1)
        {
            i -= 1; 
            cockPitCamera.SetActive(false);
            mainAudioSource.Play();
            flightAudioSource.Stop();
            i = 0; 
        }

        if (!vCam5.activeInHierarchy)
        {
            bool cameraActive = true;
            if (cameraActive == true && vCam5 == null || cameraActive == true && vCam5.active.Equals(true))
            {
                cameraActive = false;
                if (cameraActive == false)
                {
                    mainCamera.transform.LookAt(gameObject.transform.position);
                }
            }
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
