using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaker : MonoBehaviour
{
   void OnDrawGizmos(){
        RaycastHit hit;

        if(Physics.Raycast(transform.position, -Vector3.up, out hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.green);
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(hit.point, 2.5f);
        }
   }

}
