using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    void OnTriggerEnter(){
        Destroy(gameObject);
    }
}
