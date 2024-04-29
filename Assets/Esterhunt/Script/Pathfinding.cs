using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;


public class Pathfinding : MonoBehaviour
{
    // Adjust the speed for the application.
    public float speed = 2.0f;

    public GameObject target;



    void Start(){
        target = GameObject.Find("Caravan");
    }
    void Update()
    {
        
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,target.transform.position , speed);
    }


}
