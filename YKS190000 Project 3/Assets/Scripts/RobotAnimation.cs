using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class RobotAnimation : MonoBehaviour
{
    private Animator robotAnimator;
    private void Start()
    {
        robotAnimator = GetComponent<Animator>();
    }

    public void ActivateAnim()
    {
        Debug.Log("activate robot anim");
        robotAnimator.SetTrigger("Tri_Activate");
    }
    public void DeactivateAnim()
    {
        robotAnimator.SetTrigger("Tri_Deactivate");
    }
}
