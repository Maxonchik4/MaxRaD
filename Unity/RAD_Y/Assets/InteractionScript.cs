using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    Rigidbody Ana;
    // Start is called before the first frame update
    void Start()
    {
        Ana = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        Ana.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);
    }
}
