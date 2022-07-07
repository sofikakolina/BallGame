using UnityEngine;
// using System;
// using System.Collections;
// using System.Collections.Generic;
public class Test : MonoBehaviour
{

    public GameObject[] objs = new GameObject[3];
    public Transform target;

    public Light light;
    public Transform[] transforms = new Transform[3];
    public float speed = 5.0f;
    public float RotateSpeed = 10f;
    private void Start() {
    }

    private void Update() {
        for (int i=0;i<transforms.Length;i++){
            if (transforms[i]==null){
                continue;
            }
            transforms[i].Translate(new Vector3(-1,0,0)*speed*Time.deltaTime);
            transforms[i].Rotate(new Vector3(1,0,0)*RotateSpeed*Time.deltaTime);
            float posX = transforms[i].position.x;
            if ((posX<-10f || posX>10f)){
                Destroy(transforms[i].gameObject);
            }
        }

    }
    

}
