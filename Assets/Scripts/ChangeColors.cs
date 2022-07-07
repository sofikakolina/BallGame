using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    private MeshRenderer mesh;

    private void Awake() {
        mesh = GetComponent<MeshRenderer>();    
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.G)){
            mesh.material.color = Color.green;
        }
        if(Input.GetKeyDown(KeyCode.R)){
            mesh.material.color = Color.red;
        }
    }
}
