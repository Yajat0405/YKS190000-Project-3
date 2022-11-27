using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    private float _rangeOfAwareness = 35f;
    private bool _targetWithinRange = false;

    private void DetectPlayerRange()
    {
        float _currentDist = Vector3.Distance(transform.position, playerTransform.position);
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
    public void CrouchedAwareness()
    {
        _rangeOfAwareness = 5f;
    }
    public void NormalAwareness()
    {
        _rangeOfAwareness = 35f;
    }
}
