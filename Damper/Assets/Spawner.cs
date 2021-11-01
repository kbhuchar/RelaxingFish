using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public string song; 
    public List<GameObject> spawnPool;
    public Dictionary<string, float> noteDictionary = new Dictionary<string, float>(){
        {"2",(float)4.43},
        {"B",(float)3.18},
        {"A",(float)1.98},
        {"G",(float)0.68},
        {"F",(float)-0.57},
        {"E",(float)-1.82},
        {"D",(float)-3.07},
        {"1",(float)-4.32}
    };

    public GameObject quad;
    // Start is called before the first frame update
    void Start()
    {
        string[] notes = song.Split(',');
        StartCoroutine(waiter(notes));
    }
    IEnumerator waiter(string[] notes){
        foreach(var note in notes){
            spawnObjects(note);
            yield return new WaitForSeconds(2);
        }
    }
    public void spawnObjects(string note)
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
