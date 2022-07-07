using System;
using UnityEngine;
using System.Collections;
public class CreatObjects : MonoBehaviour
{
    public GameObject[] obj;

    private void Update() {
        //for(int i=0;i<4;i++) Invoke("Create",2f);
        if(Input.GetKeyUp(KeyCode.U))
            StartCoroutine(Create3dObjects(2f));

    }
    private int RandomNum(){
        return UnityEngine.Random.Range(0,10);
    }

    private void Create() {
        for (int i=0;i<5;i++){
            //GameObject newObject = Instantiate(obj,new Vector3(0,5,0),Quaternion.Euler(12f,-15f,40f)) as GameObject;
            //newObject.GetComponent<Transform>().position = new Vector3(5,5,0);
            Instantiate(obj[UnityEngine.Random.Range(0,obj.Length)],new Vector3(RandomNum(),0,RandomNum()),Quaternion.Euler(RandomNum(),-15f,40f));
        }
    }

    
    private IEnumerator Create3dObjects(float wait){
        while(true){
            Instantiate(obj[UnityEngine.Random.Range(0,obj.Length)],new Vector3(RandomNum(),0,RandomNum()),Quaternion.Euler(RandomNum(),-15f,40f));
            yield return new WaitForSeconds(wait);
            Debug.Log("Create!");
        }
    }


}
