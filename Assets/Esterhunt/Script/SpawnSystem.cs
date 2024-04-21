using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.XR.GoogleVr;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public GameObject[] SpawnPoints;
    [SerializeField]
    private GameObject Enemy;

    public const int SecondsInMinutes = 60;
    public float MinutesDuration = 180f;

    public float totalTime = 0f;
    public float currentTime = 0f;
    // Start is called before the first frame update

    void Update(){
        totalTime += Time.deltaTime;
        currentTime = totalTime %  MinutesDuration;
        
        if(currentTime >= MinutesDuration){
            Debug.Log("Spawn");
            SpawnObjects();
        }
        
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

        IEnumerator SpawnTimer(float x){
            yield return new WaitForSeconds(x);
            SpawnObjects();
        }

}
