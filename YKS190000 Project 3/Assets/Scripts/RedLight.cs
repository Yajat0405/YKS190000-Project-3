using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLight : MonoBehaviour
{
    [SerializeField] GameObject _RedLight;
    IEnumerator WaitForSecs(bool _bool)
    {
        yield return new WaitForSeconds(1);
        _RedLight.SetActive(_bool);
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
