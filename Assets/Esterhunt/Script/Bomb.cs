using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;


public class Bomb : MonoBehaviour
{

    [SerializeField]
    private GameObject DebriPrefab;
    [SerializeField]
    private float Radius;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground"){
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 Center = contact.point;
            GameObject debriPart = Instantiate(DebriPrefab, Center, rotation);

            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            if(rb != null){
                Debug.Log("Exposion");
                Debug.Log(gameObject);
                rb.AddExplosionForce(Random.Range(10f, 100f),Center, Radius);
                // rb.AddExplosionForce(Random.Range(10f, 100f),Center , Radius, 0.0f, ForceMode.Force);
            }
            Destroy(gameObject);
        }
    }



}
