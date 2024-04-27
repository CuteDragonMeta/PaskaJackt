using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(LineRenderer))]

public class Pathfinding : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GoalObject;
    public NavMeshAgent agent;
    private LineRenderer myLineRenderer;
    

      
    void Start()
    {
        Vector3 goal = GoalObject.transform.position;
        agent.SetDestination(goal);
        myLineRenderer = GetComponent<LineRenderer>();
        //Default value for line
        myLineRenderer.startWidth = 0.15f;
        myLineRenderer.endWidth = 0.15f;
        myLineRenderer.positionCount = 0;

    }

    void Update()
    {
        if(agent.hasPath){
            DrawPath();
        }
    }
    // will draw the path the Enemy will take to reach its destination
    void DrawPath(){
        myLineRenderer.positionCount = agent.path.corners.Length;
        myLineRenderer.SetPosition(0, transform.position);

        if(agent.path.corners.Length < 2){
            return;
        }

        for(int i = 1; i < agent.path.corners.Length; i++){
            Vector3 pointPosition = new Vector3(agent.path.corners[i].x,agent.path.corners[i].y,agent.path.corners[i].z);
            myLineRenderer.SetPosition(i, pointPosition);
        }
    }
}
