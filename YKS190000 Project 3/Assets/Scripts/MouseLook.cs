using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouseLook : MonoBehaviour
{
    float mouseSensitivity = 100f;

    public Transform playerBody;
    float xRotation = 0f;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    IEnumerator LockTimer()
    {
        yield return new WaitForSeconds(5);
        ResumeMouse();
    }
    public void LockMouse()
    {
       mouseSensitivity = 0f;
        StartCoroutine(LockTimer());
    }

    public void ResumeMouse()
    {
        mouseSensitivity = 100f;
    }

    public void HalfMouse()
    {
        mouseSensitivity = 50f;
    }
}

