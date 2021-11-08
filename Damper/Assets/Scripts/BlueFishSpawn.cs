using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFishSpawn: MonoBehaviour
{
    public GameObject independent;
    public GameObject dependent;
    // Start is called before the first frame update
    void Start()
    {
        dependent.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {


        if (independent.transform.position.x > 0.7)
        {
            dependent.SetActive(true);
        }

    }
}
