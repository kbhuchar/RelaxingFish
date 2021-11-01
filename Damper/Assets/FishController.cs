using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    gameManager GameManager;
    int count = 0;

    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<-5.28f)
        {
            transform.position += new Vector3(0.5f * Time.deltaTime, 0.5f * Time.deltaTime, 0);
        }
        if(transform.position.x>= -5.28f && transform.position.x<-3.20)
        {
            transform.position += new Vector3(0.5f * Time.deltaTime, -0.5f * Time.deltaTime, 0);
        }
        if (transform.position.x >= -3.20 && transform.position.x<-1.5)
        {
            transform.position += new Vector3(0.5f * Time.deltaTime, 0.5f * Time.deltaTime, 0);
        }
        if (transform.position.x >= -1.5 && transform.position.x < 0.5f) 
        {
            transform.position += new Vector3(0.5f * Time.deltaTime, -0.5f * Time.deltaTime, 0);
        }
        if (transform.position.x >= 0.5f && transform.position.x < 2.00f)
        {
            transform.position += new Vector3(0.5f * Time.deltaTime, 0.5f * Time.deltaTime, 0);
        }
        if (transform.position.x >= 2.00f && transform.position.x < 4.50f)
        {
            transform.position += new Vector3(0.5f * Time.deltaTime, -0.5f * Time.deltaTime, 0);
        }
        if (transform.position.x >= 4.50f && transform.position.x < 6.00f)
        {
            transform.position += new Vector3(0.5f * Time.deltaTime, 0.5f * Time.deltaTime, 0);
        }
        if (transform.position.x >= 6.00f && transform.position.x < 8.0f)
        {
            transform.position += new Vector3(0.5f * Time.deltaTime, -0.5f * Time.deltaTime, 0);
        }

    }
}
