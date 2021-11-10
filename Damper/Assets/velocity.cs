using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
  Vector3 pos1, pos2, finalPos;
  private float speed = 2f;
  private float rotate = 0.5f;

  Vector3 nextPos;

  void Start(){
    //north to south
    if(transform.position.y==5.8f){
      pos1 = new Vector3 (Random.Range(-6f,6f),3f);
      pos2 = new Vector3 (Random.Range(-6f,6f),-3f);
      finalPos = new Vector3 (Random.Range(-8.4f,8.4f),-5.8f);
    }
    //south to north
    else if(transform.position.y==-5.8f){
      pos1 = new Vector3 (Random.Range(-6f,6f),-3f);
      pos2 = new Vector3 (Random.Range(-6f,6f),3f);
      finalPos = new Vector3 (Random.Range(-8.4f,8.4f),5.8f);
    }
    //east to west
    else if(transform.position.x==9f){
      pos1 = new Vector3 (6f,Random.Range(-3f,3f));
      pos2 = new Vector3 (-6f,Random.Range(-3f,3f));
      finalPos = new Vector3 (-9f,Random.Range(-5.8f,5.8f));
    }
    //west to east
    else{
      pos1 = new Vector3 (-6f,Random.Range(-3f,3f));
      pos2 = new Vector3 (6f,Random.Range(-3f,3f));
      finalPos = new Vector3 (9f,Random.Range(-5.8f,5.8f));
    }
    nextPos = pos1;
  }

  void Update(){
    if(transform.position==pos1){
      nextPos = pos2;
    }
    if(transform.position==pos2){
      nextPos = finalPos;
    }
    if(transform.position==finalPos){
      Destroy(gameObject);
    }
    Vector3 v2t = nextPos - transform.position;
    float angle = Mathf.Atan2(v2t.y,v2t.x)*Mathf.Rad2Deg;
    Quaternion qt = Quaternion.AngleAxis(angle,Vector3.forward);
    transform.Rotate(nextPos,rotate * Time.deltaTime);

    transform.position = Vector3.MoveTowards(transform.position,nextPos,speed * Time.deltaTime);
  }
}
