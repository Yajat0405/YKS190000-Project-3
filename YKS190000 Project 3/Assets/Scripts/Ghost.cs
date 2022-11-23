using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] GameObject player;
    private float _rangeOfAwareness = 35f;
    private bool _targetWithinRange = false;

    private void DetectPlayerRange()
    {
        float _currentDist = Vector3.Distance(transform.position, target.position);
        if (_currentDist < _rangeOfAwareness)
        {
            _targetWithinRange = false;
            //no cinematic yet
        }
        else
        {
            _targetWithinRange = true;
            //cinematic starts player stops 
        }
    }
}
