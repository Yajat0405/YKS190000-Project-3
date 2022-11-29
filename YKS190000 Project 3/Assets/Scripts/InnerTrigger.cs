using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerTrigger : MonoBehaviour
{
    [SerializeField] GameObject robotGeo;
    private void OnTriggerEnter(Collider other)
    {
        robotGeo.GetComponent<RobotAnimation>().activateSpin();
    }

    IEnumerator LockTimer()
    {
        yield return new WaitForSeconds(3);
        robotGeo.GetComponent<SpinAnim>().deactivateSpin();
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited TriggerVol");
        StartCoroutine(LockTimer());

        Debug.Log("Robot Deactivated");
    }
}
