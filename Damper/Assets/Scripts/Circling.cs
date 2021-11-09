using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circling : MonoBehaviour
{
    float timeCounter = 0;
    public float speed;
    public float height;
    public float width;
    bool clicked;
    bool circling = false;
    Vector3 clickedPos;
    [SerializeField]private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (clicked == true){
            Debug.Log("Clicked");
            timeCounter += Time.deltaTime*speed;

        
           float x = Mathf.Cos(timeCounter)*width;
           float y = Mathf.Sin(timeCounter)*height;
           float z = 0;

            transform.position = clickedPos + new Vector3(x,y,z);
            Debug.Log(x);
            //transform.Rotate(rotation * Time.deltaTime);
            
        }
    
    }
    void OnMouseDown(){
        if(circling == false){
        clicked = true;
        circling = true;
        clickedPos = transform.position;
        return;
        }
        if(circling == true){
            clicked = false;
            circling = false;
        }
    }
    
}
