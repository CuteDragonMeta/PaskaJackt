using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    [SerializeField]
    private GameObject explosionPrefab;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground"){
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = contact.point;
            Instantiate(explosionPrefab, position, rotation);
            Destroy(gameObject);
        }
    }
}
