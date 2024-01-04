using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering; 
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] private GameObject triggerObject;
    [SerializeField] private Volume volume; 

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("GameController"))
        {
            volume.enabled = true;
            return; 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("GameController") && gameObject.name == "TriggerZone4")
        {
            SceneManager.LoadSceneAsync(1);
            print("end sequence"); return;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GameController"))
        {
            volume.enabled = false;
            return;
        }
    }
}
