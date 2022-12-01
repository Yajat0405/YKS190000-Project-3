using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerTrigger : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject cameraController;

    public AudioClip _dangerClip;
    public AudioSource _dangerSource;

    private float fixedDeltaTime;

    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        _dangerSource.PlayOneShot(_dangerClip, 1);
        Time.timeScale = 2f;
        player.GetComponent<PlayerMovement>().HalfSpeed();
        cameraController.GetComponent<MouseLook>().HalfMouse();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited TriggerVol");
        Time.timeScale = 1f;
        player.GetComponent<PlayerMovement>().ResumeMovement();
        Debug.Log("Robot Deactivated");
    }
}
