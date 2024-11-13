using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AddAnimationrScript : MonoBehaviour

{
    Animator edAnimator;
    float speed = 1;
    float WalkingSpeed = 1;
    float RunningSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        edAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        edAnimator.SetBool("IsWalking", false);
        edAnimator.SetBool("IsRunning", false);
        speed = 0;
        


        if (Input.GetKey(KeyCode.W))
        {
            edAnimator.SetBool("IsWalking", true);
            speed = WalkingSpeed;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                edAnimator.SetBool("IsRunning", true);

                speed = RunningSpeed;
            }
        }




            transform.position += speed * transform.forward * Time.deltaTime;
        }
}
