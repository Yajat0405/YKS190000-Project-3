using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SpinAnim : MonoBehaviour
{
    private Animator robotAnimator; 
    private void Start()
    {
        robotAnimator = GetComponent<Animator>();
    }

    public void activateSpin()
    {
        robotAnimator.SetTrigger("Tri_SpinActivate");
    }
    public void deactivateSpin()
    {
        robotAnimator.SetTrigger("Tri_SpinDeactivate");
    }
}
