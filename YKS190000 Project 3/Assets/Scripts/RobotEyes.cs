using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEyes : MonoBehaviour
{
    [SerializeField] Transform _ghost;
    private void Update()
    {
        transform.LookAt(_ghost);
    }
}
