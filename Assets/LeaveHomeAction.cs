using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveHomeAction : MonoBehaviour
{
    public GameObject txt;
    public GameObject bttn; 

   public void LeaveHome()
    {
        if(Application.isPlaying)
        {
            txt.SetActive(true);
            bttn.SetActive(true); 
        }
    }
}
