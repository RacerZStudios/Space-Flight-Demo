using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveApp : MonoBehaviour
{
   public void LeaveAppMethod()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
