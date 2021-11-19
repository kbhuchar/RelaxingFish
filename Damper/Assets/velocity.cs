using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
  Vector3 pos1, pos2, finalPos;
  private float speed = 2f;
  private float rotate = 0.5f;
  [SerializeField]private Vector3 rotation;
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
    Rotate(nextPos);
  }

  void Update(){
    if(transform.position==pos1){
      nextPos = pos2;
      Rotate(nextPos);
    }
    if(transform.position==pos2){
      nextPos = finalPos;
      Rotate(nextPos);
    }
    if(transform.position==finalPos){
      Destroy(gameObject);
    }
    transform.position = Vector3.MoveTowards(transform.position,nextPos,speed * Time.deltaTime);
  }
  void Rotate(Vector3 pos){
    Vector3 v2t = pos - transform.position;
    float angle = Mathf.Atan2(v2t.y,v2t.x)*Mathf.Rad2Deg;
    //It's that easy boys
    transform.localRotation = Quaternion.Euler(new Vector3(0,0,angle));
  }
}
