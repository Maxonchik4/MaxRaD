using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    Rigidbody Ana;
    float ExplosionRadius = 10;
    float ExplosionStrenght = 1000;
    // Start is called before the first frame update
    void Start()
    {


        Ana = GetComponent<Rigidbody>();
        Ana.AddForce(10 * transform.forward, ForceMode.Impulse);

    }


    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimColliders = Physics.OverlapSphere(transform.position, ExplosionRadius);
        foreach (Collider collider in allVictimColliders)
        {

            PersonScript personVictim = collider.GetComponent<PersonScript>();
            if (personVictim != null)
            {

                personVictim.ExplosionAt(transform.position, ExplosionRadius, ExplosionStrenght);
            }
            else
            {


                Rigidbody rigitbody = collider.GetComponent<Rigidbody>();
                if (rigitbody != null)

                {
                    rigitbody.AddExplosionForce(ExplosionStrenght, transform.position, ExplosionRadius);

                }
            }

            Destroy(gameObject);
        }
    }
}

    // Update is called once per frame

 