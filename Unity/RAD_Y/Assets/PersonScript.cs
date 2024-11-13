using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonScript : MonoBehaviour
{
    int Health = 100;
    int damage = 15;
    Rigidbody rb;
    internal void ExplosionAt(Vector3 position, float explosionRadius, float explosionStrength)
    {
        Health -= damage;
        print("Ouch my health is now:" + Health.ToString());
        rb.AddExplosionForce(explosionStrength, position, explosionRadius);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
