using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public class BombSpawning : MonoBehaviour
{
    [SerializeField]
    private GameObject Bomb;
    private IEnumerator coroutine;
    public bool Pressed;

    


    void Update()
    {

        if(Pressed == true){
            
            Instantiate(Bomb,Bomb.transform.localPosition + new Vector3(0,0.5f,0), quaternion.identity);
            Pressed = false;

        }
    }
    private void CreateBomb(){
            new Vector3(0,0,0);
            }


}
