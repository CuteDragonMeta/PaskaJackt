using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public GameObject[] SpawnPoints;
    [SerializeField]
    private GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects(){
        List<GameObject> tempSpawnPoints = new List<GameObject>();
        tempSpawnPoints.AddRange(SpawnPoints);

        for(int e = 0; e<2; e++){
            RaycastHit hit;
            if(Physics.Raycast(tempSpawnPoints[e].transform.position, -Vector3.up, out hit)){
                Vector3 location = new Vector3(hit.point.x, hit.point.y + 0.5f, hit.point.z);
                GameObject poolSpawned = Instantiate(Enemy, location, transform.rotation);
                Debug.Log(location);
            }
        }
        }
}
