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
        robotAnimator.SetTrigger("Tri_Activate");
    }
    public void deactivateAnim()
    {
        robotAnimator.SetTrigger("Tri_Deactivate");
    }
    public void clapAnim()
    {
        robotAnimator.SetTrigger("Tri_Clap");
    }
}
