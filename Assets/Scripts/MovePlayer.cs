
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5f, hspeed = 10f,trust=500f;
    private Rigidbody rb;
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate() {
        float h = Input.GetAxis("Horizontal")*hspeed*Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical")*speed*Time.fixedDeltaTime;

        rb.velocity = transform.TransformDirection(new Vector3(h,rb.velocity.y,v));
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Block"){
            rb.AddForce(new Vector3(0,1,0)*trust); 
        }
    }
    private void OnCollisionStay(Collision other) {
        if (other.gameObject.name == "Block"){
            rb.AddForce(new Vector3(0,1,0)*trust); 
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Trigger"){
            Debug.Log("Trigger Correct");
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.name == "Trigger"){
            Destroy(gameObject);

        }
    }
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "Trigger"){
            Debug.Log("Trigger Stay");
        }
    }
    

    
}
