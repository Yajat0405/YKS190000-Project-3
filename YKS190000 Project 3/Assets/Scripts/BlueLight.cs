using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLight : MonoBehaviour
{
    [SerializeField] GameObject _BlueLight;
    IEnumerator WaitForSecs()
    {
        yield return new WaitForSeconds(3);
        _BlueLight.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(WaitForSecs());
    }
}
