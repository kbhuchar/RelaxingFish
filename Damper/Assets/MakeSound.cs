using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSound : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        GetComponent<AudioSource>().Play();
    }
}
