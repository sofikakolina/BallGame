
using UnityEngine;

public class EnableLight : MonoBehaviour
{

    public Light mainLight;

    private void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            mainLight.enabled = !mainLight.enabled;
        }
    }
    
}
