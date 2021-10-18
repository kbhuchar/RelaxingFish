using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numSpawn;
    public List<GameObject> spawnPool;
    public float[] NoteLocation = new float[]{-4.5f,-3f,-1.5f,0f,1.5f,3f,4.5f};

    public GameObject quad;
    // Start is called before the first frame update
    void Start()
    {
        spawnObjects();
    }

    public void spawnObjects()
    {
        int randomItem = 0;
        int randomNote = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for(int i = 0; i<numSpawn; i++){
            randomItem = Random.Range(0,spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = c.bounds.min.x;

            randomNote = Random.Range(0, NoteLocation.Length);
            screenY = NoteLocation[randomNote];
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
