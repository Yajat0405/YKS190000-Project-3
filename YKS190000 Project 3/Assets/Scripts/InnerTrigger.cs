using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerTrigger : MonoBehaviour
{
    [SerializeField] GameObject robotGeo;
    private void OnTriggerEnter(Collider other)
    {
        //robotGeo.GetComponent<SpinAnim>().ActivateSpin();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited TriggerVol");
        //robotGeo.GetComponent<SpinAnim>().DeactivateSpin();
        robotGeo.GetComponent<RobotAnimation>().activateAnim();
        Debug.Log("Robot Deactivated");
    }
}
