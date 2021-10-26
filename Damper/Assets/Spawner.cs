using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public string note; 
    public List<GameObject> spawnPool;
    public Dictionary<string, float> noteDictionary = new Dictionary<string, float>(){
        {"C",(float)4.5},
        {"B",(float)3},
        {"A",(float)1.5},
        {"G",(float)0},
        {"F",(float)-1.5},
        {"E",(float)-3},
        {"D",(float)-4.5}
    };

    public GameObject quad;
    // Start is called before the first frame update
    void Start()
    {
        spawnObjects();
    }

    public void spawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for(int i = 0; i<note.Length; i++){
            randomItem = Random.Range(0,spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = c.bounds.min.x;

            screenY = noteDictionary[note[i].ToString()];
            pos = new Vector2(screenX,screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }

    private void destroyObject(){
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("spwanable")){
            Destroy(o);
        }
    }
}
