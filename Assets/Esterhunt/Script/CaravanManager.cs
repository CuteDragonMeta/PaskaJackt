using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanManager : MonoBehaviour
{
    private float fixedRotation = 0;
    [SerializeField]
    private int C_Speed;
    public Rigidbody C_Rigidbody;

    [SerializeField]
    private int C_HP;
    
    void Start(){
        C_HP = 50;
    }

    void Update()
    {
        C_Rigidbody.velocity = new Vector3(C_Speed,0,0);
        Vector3 eulerAngles = transform.eulerAngles;
		transform.eulerAngles = new Vector3( eulerAngles.x , fixedRotation , eulerAngles.z );
        
    }

    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.CompareTag("Enemy")){
            C_HP -= 5;
            if(C_HP == 0){
                GameOver();
            }
        }
    }
    void GameOver(){
        print("Gameover");
    }
}
