using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVol : MonoBehaviour
{
    [SerializeField]GameObject robotGeo;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered TriggerVol");
        robotGeo.GetComponent<RobotAnimation>().activateAnim();
        Debug.Log("Robot Activated");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited TriggerVol");
        robotGeo.GetComponent<RobotAnimation>().deactivateAnim();
        Debug.Log("Robot Deactivated");
    }
}
