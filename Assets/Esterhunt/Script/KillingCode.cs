using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingCode : MonoBehaviour
{
    [SerializeField]
    private GameObject Explosion;
    [SerializeField]
    private GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        if (Vector3.Distance (Explosion.transform.position, Enemy.transform.position) <= 3)
        {
            //Do something because the distance is less or equal than 3   
            Debug.Log("HIT");
            Destroy(Enemy);
            // Time.timeScale = 1.0f;
            StartCoroutine(settles(3f, Explosion));
        } else{
            // Time.timeScale =1.0f;
            StartCoroutine(settles(3f, Explosion));
        }
    }

   IEnumerator settles(float x, GameObject item){
    yield return new WaitForSeconds(x);
    Destroy(item);
   }
}
