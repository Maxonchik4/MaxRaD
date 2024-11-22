using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHeroScript : MonoBehaviour
{
    float runningSpeed = 3f;
    // Start is called before the first frame update
    float turnSpeed = 100f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += runningSpeed * transform.forward * Time.deltaTime;
        }



        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime;
        }



        if (Input.GetKey(KeyCode.D))

        {
            transform.Rotate(Vector3.up, 45 * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime); // Rotate left by negating turnSpeed
        }

        if (Input.GetKey(KeyCode.Space))

        {
            transform.position += runningSpeed * transform.up * Time.deltaTime;

        }

    }
}
