using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVol : MonoBehaviour
{
    [SerializeField]GameObject robotGeo;
    [SerializeField] GameObject cameraController;
    [SerializeField] GameObject player;

    public AudioClip _thunderClip;
    public AudioSource _thunderSource;
    private float fixedDeltaTime;

    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered TriggerVol");
        _thunderSource.PlayOneShot(_thunderClip, 1);
        Time.timeScale = 0.6f;
        StartCoroutine(stopSlowMotion());
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

    IEnumerator stopSlowMotion()
    {
        yield return new WaitForSeconds(5);
        Time.timeScale = 1.0f;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited TriggerVol");
        StartCoroutine(LockTimer());
        
        Debug.Log("Robot Deactivated");
    }

}
