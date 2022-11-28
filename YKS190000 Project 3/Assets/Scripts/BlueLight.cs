using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLight : MonoBehaviour
{
    [SerializeField] GameObject _BlueLight;
    IEnumerator WaitForSecs(bool _bool)
    {
        yield return new WaitForSeconds(2);
        _BlueLight.SetActive(_bool);
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(WaitForSecs(true));
    }

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(WaitForSecs(false));
    }
}
