using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator m_anim;
    [SerializeField]
    private StarterAssetsInputs controller;
	//this not required but it makes this much easier, I convert the string Speed to int
	//you don't have to do this
	//https://docs.unity3d.com/ScriptReference/Animator.StringToHash.html
	//https://stackoverflow.com/questions/40190241/what-is-the-benefit-of-using-animator-stringtohash
    private readonly int SPEED = Animator.StringToHash("Speed");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//get the speed from the controller (no matter the direction)
		//I care only the length
        float speed = controller.move.magnitude;
        if(speed > 0)
        {
			//check if the controller is sprinting 
            if (controller.sprint)
                m_anim.SetFloat(SPEED, 1);
			//if not it is half
            else
                m_anim.SetFloat(SPEED, 0.5f);
        }
		//when speed is zero, be in idle
        else
            m_anim.SetFloat(SPEED, 0f);
    }
}
