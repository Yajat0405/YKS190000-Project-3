using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject zoomCam;
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCam.SetActive(false);
            zoomCam.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            mainCam.SetActive(true);
            zoomCam.SetActive(false);
        }
    }
}
