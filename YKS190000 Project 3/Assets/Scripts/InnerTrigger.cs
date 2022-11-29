using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerTrigger : MonoBehaviour
{
    [SerializeField] GameObject robotGeo;
    [SerializeField] GameObject player;
    [SerializeField] GameObject cameraController;

    private float fixedDeltaTime;

    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 2f;
        player.GetComponent<PlayerMovement>().halfSpeed();
        cameraController.GetComponent<MouseLook>().halfMouse();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited TriggerVol");
        Time.timeScale = 1f;
        player.GetComponent<PlayerMovement>().resumeMovement();
        Debug.Log("Robot Deactivated");
    }
}
