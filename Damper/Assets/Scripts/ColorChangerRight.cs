using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerRight : MonoBehaviour
{
    public Color colorStart;
    public Color colorEnd;
    public float range1;
    public float range2;
    float duration;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
    rend = GetComponent<Renderer> ();
    duration = Random.Range(range1, range2);
    colorStart.a = 1.0f;
    colorEnd.a = 1.0f;
    //Debug.Log(duration);
    }

    // Update is called once per frame
    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        //Debug.Log("Color Start: " + colorStart + " Color End: " + colorEnd);
        rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);

    }
}
