using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVol : MonoBehaviour
{
    [SerializeField]GameObject robotGeo;
    [SerializeField] GameObject cameraController;
    [SerializeField] GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered TriggerVol");
        robotGeo.GetComponent<RobotAnimation>().activateAnim();
        cameraController.GetComponent<ZoomCamera>().startCinema();
        cameraController.GetComponent<MouseLook>().lockMouse();
        player.GetComponent<PlayerMovement>().lockMovement();
        Debug.Log("Robot Activated");
    }

    IEnumerator LockTimer()
    {
        yield return new WaitForSeconds(3);
        robotGeo.GetComponent<RobotAnimation>().deactivateAnim();
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited TriggerVol");
        StartCoroutine(LockTimer());
        
        Debug.Log("Robot Deactivated");
    }

}
