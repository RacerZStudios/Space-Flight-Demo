using System.Collections;
using System.Collections.Generic;
using UnityEngine.Timeline;
using UnityEngine;
using Cinemachine;

public class CinemaCam : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera;
    [SerializeField] private GameObject vCam;
    [SerializeField] private GameObject disableCamera;  
    private int keyPress; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && Time.time >= 5 && keyPress <= 0)
        {
            keyPress += 1; 
            camera.enabled = true;
            vCam.SetActive(true); 
            keyPress = 1; 
        }
        else if(Time.time > 5 && Input.GetKeyDown(KeyCode.Alpha1) && keyPress >= 1)
        {
            keyPress -= 1;
            camera.enabled = false;
            vCam.SetActive(false);
            keyPress = 0; 
        }

        //if(vCam.Equals(true) && camera.enabled == true)
        //{
        //    disableCamera.SetActive(false);
        //    return; 
        //}
    }
}
