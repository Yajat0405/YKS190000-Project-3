using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject zoomCam;

    IEnumerator CinematicTimer()
    {
        yield return new WaitForSeconds(5);
        EndCinema();
    }
    public void StartCinema()
    {
        mainCam.SetActive(false);
        zoomCam.SetActive(true);
        StartCoroutine(CinematicTimer());
    }

    public void EndCinema()
    {
        mainCam.SetActive(true);
        zoomCam.SetActive(false);
    }
        
}
