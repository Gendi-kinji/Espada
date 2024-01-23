using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Fire;
    public float spawnRate=2;
    public float timer=0;
    public float heightOffset=10;
    // Start is called before the first frame update
    void Start()
    {
       SpawnFire(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer+=Time.deltaTime;

        }else{
        SpawnFire();
        timer=0;
        }
        
    }
    void SpawnFire(){
        float lowestPoint=transform.position.y-heightOffset;
        float highestPoint=transform.position.y+heightOffset;
        Instantiate(Fire,new Vector3(transform.position.x,Random.Range(lowestPoint, highestPoint),0),transform.rotation);
    }
}