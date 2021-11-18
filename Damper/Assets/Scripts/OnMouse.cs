using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse : MonoBehaviour
{
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        effect.SetActive(false);
    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        effect.SetActive(true);
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        effect.SetActive(false);
        Debug.Log("Mouse is no longer on GameObject.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


