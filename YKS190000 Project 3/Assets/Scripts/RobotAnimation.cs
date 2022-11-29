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

    public void activateAnim()
    {
        Debug.Log("activate robot anim");
        robotAnimator.SetTrigger("Tri_Activate");
    }
    public void deactivateAnim()
    {
        robotAnimator.SetTrigger("Tri_Deactivate");
    }
}
