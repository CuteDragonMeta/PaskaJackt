using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingCode : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Bomb"){
            Debug.Log("Hit");
            Debug.Log(gameObject);
            Destroy(gameObject);
            settles(3f, gameObject);
        }
    }

   IEnumerator settles(float x, GameObject item){
    yield return new WaitForSeconds(x);
    Destroy(item);
   }
}
