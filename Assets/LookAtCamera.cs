using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] Camera _camera;
    [SerializeField] Transform myTransform;
    [SerializeField] Transform followPos; 

    private void LateUpdate()
    {
        if(_camera.enabled)
        {
            if (_camera != null || myTransform != null)
            {
                _camera.transform.LookAt(myTransform);
                _camera.gameObject.transform.position = followPos.position;
            }
        }
        return; 
    }
}
