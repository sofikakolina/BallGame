using UnityEngine.UI;
using UnityEngine;

public class PlayerCntrl : MonoBehaviour
{
    public float speed = 5f;
    private int score=0;
    private Rigidbody rb;
    public Text scoreText;
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(h,1,v)*speed*Time.fixedDeltaTime); 
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="CollectiveCube"){
            score++;
            Destroy(other.gameObject);
            if (score != 6)
                scoreText.text = "Score: "+ score;
            else scoreText.text = "You Win!";
        }
    }
}
