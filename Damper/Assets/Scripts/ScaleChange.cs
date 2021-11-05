using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
   
    private GameObject fish;
    private GameObject redfish;
    private GameObject bluefish;
    private Vector3 scaleChange;
    private float deltaTime = 2.0f;
    private bool up_scale = true;
    void Start()
    {
        fish = GameObject.FindGameObjectWithTag("Startingfish");
        redfish = GameObject.FindGameObjectWithTag("redfish");
        bluefish = GameObject.FindGameObjectWithTag("BlueFish");
        StartCoroutine(FishCoroutine());
    }
    
    IEnumerator FishCoroutine()
    {
        while (true)
        {
            while (up_scale)
            {
                yield return new WaitForSeconds(0.5f);

                fish.transform.localScale += new Vector3(0.1f, 0.001f, 0);
                redfish.transform.localScale += new Vector3(-0.02f, -0.2f, 0);
                bluefish.transform.localScale += new Vector3(0.02f, 0.2f, 0);

                yield return new WaitForSeconds(0.5f);


                fish.transform.localScale += new Vector3(-0.1f, -0.001f, 0);
                redfish.transform.localScale += new Vector3(0.02f, 0.2f, 0);
                bluefish.transform.localScale += new Vector3(-0.02f, -0.2f, 0);
            }
        }
    }
    
}



