using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationTrigger : MonoBehaviour
{

    private Animator robotAnimator;
    private void Start()
    {
        robotAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (robotAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                robotAnimator.SetTrigger("Tri_Activate");
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                robotAnimator.SetTrigger("Tri_Deactivate");
            }

        }
        
    }
}
