using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circling : MonoBehaviour
{
    static int fishCount = 0;
    public static List<GameObject> fish = new List<GameObject>();
    float timeCounter = 0;
    public float speed;
    public float height;
    public float width;
    bool clicked;
    bool circling = false;
    Vector3 clickedPos;
    [SerializeField]private Vector3 rotation;
    public AudioClip Rhythm;
    public AudioClip Lead;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (clicked == true){
            //Debug.Log("Clicked");
            timeCounter += Time.deltaTime*speed;

        
           float x = Mathf.Cos(timeCounter)*width;
           float y = Mathf.Sin(timeCounter)*height;
           float z = 0;

            transform.position = clickedPos + new Vector3(x,y,z);
            //transform.Rotate(rotation * Time.deltaTime);
            if (fish.Count == 2){
            Debug.Log("Playing");
            int count = 1;
            foreach (GameObject f in fish){
                if (count == 1 ){
                    AudioSource audio1 = f.GetComponent<AudioSource>();
                    audio1.PlayOneShot(f.GetComponent<Circling>().Rhythm);
                }
                else if (count == 2){
                   AudioSource audio2 = f.GetComponent<AudioSource>();
                   audio2.PlayOneShot(f.GetComponent<Circling>().Lead);
                }
                count = count + 1;
            }
            fish.Clear();
            }
        }
    
    }
    void OnMouseDown(){
        if(circling == false){
        clicked = true;
        circling = true;
        clickedPos = transform.position;
        //fishCount = fishCount + 1;
        fish.Add(this.gameObject);
        Debug.Log(fish.Count);
        foreach (GameObject f in fish){
            Debug.Log(f);
        }
        return;
        }
        if(circling == true){
            fishCount = fishCount - 1;
            clicked = false;
            circling = false;
        }
    }
    
}
