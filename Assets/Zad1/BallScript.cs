using UnityEngine;

public class BallScript : MonoBehaviour {
    Rigidbody2D rb;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        Debug.Log(Input.mousePosition);
    }
    private void OnMouseUp() {
        if (Input.mousePosition.x < Screen.width / 2)
            rb.AddForce(-transform.right * 5000);
        else {
            rb.AddForce(transform.right * 5000);
        }
    }
}