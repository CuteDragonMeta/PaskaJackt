using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanManager : MonoBehaviour
{

    [SerializeField]
    private GameObject Caravan;
    [SerializeField]
    private int C_Speed;
    public Rigidbody C_Rigidbody;

    void Update()
    {
        C_Rigidbody.velocity = transform.position + new Vector3(1,0,0) * C_Speed;
    }
}
