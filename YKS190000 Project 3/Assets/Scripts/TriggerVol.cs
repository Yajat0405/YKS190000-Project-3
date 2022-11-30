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

    public AudioClip _activationClip;
    public AudioSource _activationSource;

    public AudioClip _clapClip;
    public AudioSource _clapSource;
    
    private float fixedDeltaTime;

    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered TriggerVol");
        _clapSource.loop = true;
       _thunderSource.PlayOneShot(_thunderClip, 1);
        _activationSource.PlayDelayed(1f);
        StartCoroutine(DelaySound());
        Time.timeScale = 0.6f;
        StartCoroutine(StopSlowMotion());
        robotGeo.GetComponent<RobotAnimation>().ActivateAnim();
        cameraController.GetComponent<ZoomCamera>().StartCinema();
        cameraController.GetComponent<MouseLook>().LockMouse();
        player.GetComponent<PlayerMovement>().LockMovement();
        Debug.Log("Robot Activated");
    }

    IEnumerator LockTimer()
    {
        yield return new WaitForSeconds(3);
        robotGeo.GetComponent<RobotAnimation>().DeactivateAnim();
    }

    IEnumerator StopSlowMotion()
    {
        yield return new WaitForSeconds(5);
        Time.timeScale = 1.0f;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exited TriggerVol");
        StartCoroutine(LockTimer());
        _clapSource.Pause();
        Debug.Log("Robot Deactivated");
    }

    IEnumerator DelaySound()
    {
        yield return new WaitForSeconds(2.5f);
        _clapSource.Play();
    }
}
