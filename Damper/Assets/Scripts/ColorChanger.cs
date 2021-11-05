using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
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
    //Debug.Log(duration);
    }

    // Update is called once per frame
    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);

    }
}
