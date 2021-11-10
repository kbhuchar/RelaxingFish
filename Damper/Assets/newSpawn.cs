using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpawn : MonoBehaviour
{
   public List<GameObject> spawnPool;
   public float spawnRate = 2f;
   float nextSpawn = 0.0f;
    //runtime shenanigans
    void Update(){
        //checks time agianst spawnRate
        if(Time.time > nextSpawn){
            float screenX, screenY;
            int randomItem = 0;
            GameObject toSpawn;
            Vector2 direction;
            int compass = Random.Range(0,4);
            //determines the fish to spawn from spawn pool
            randomItem = Random.Range(0,spawnPool.Count);
            toSpawn = spawnPool[randomItem];
            //creates nextSpawn time
            nextSpawn = Time.time + spawnRate;
            //North Spawn
            if(compass==0){
                screenX = Random.Range(-8.4f,8.4f);
                screenY = 5.8f;
                direction = new Vector2(0f,-1f);
            }
            //South Spawn
            else if(compass==1){
                screenX = Random.Range(-8.4f,8.4f);
                screenY = -5.8f;
                direction = new Vector2(0f,1f);
            }
            //East Spawn
            else if(compass==2){
                screenY = Random.Range(-5.8f,5.8f);
                screenX = -9f;
                direction = new Vector2(1f,0f);
            }
            //West Spawn
            else{
                screenY = Random.Range(-5.8f,5.8f);
                screenX = 9f;
                direction = new Vector2(-1f,0f);
            }
            //finds rotation
            float angle = Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle,Vector3.forward);
            //spawns in new fish
            Vector2 pos = new Vector2 (screenX, screenY);
            Instantiate(toSpawn, pos, rotation);
        }
    }
}
