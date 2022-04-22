using UnityEngine;

public class ProjectileScript : MonoBehaviour {
    Rigidbody2D rb;
    float projectileSpeed = 100;
    void Start() {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update() {
        rb.AddForce(gameObject.transform.up * projectileSpeed);
    }

}
