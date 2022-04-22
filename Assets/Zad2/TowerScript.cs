using UnityEngine;

public class TowerScript : MonoBehaviour {
    public float rotateTimer;
    public float rotateTimeDelay = 0.5f;
    public float rotationValue;

    public float spawnProjectilesTimer;

    [SerializeField]
    public float spawnProjectilesTimerDelay = 0.3f;

    public int projectileCount = 0;


    [SerializeField]
    private GameObject objectToBeSpawned;
    void Update() {
        if (ShouldRotate()) {
            RotateAgent();
        }

    }
    private void RotateAgent() {
        rotateTimer = Time.time + rotateTimeDelay;
        rotationValue = Random.Range(15, 45);
        gameObject.transform.Rotate(0, 0, rotationValue);
        if (projectileCount < 14)
            SpawnProjectiles();
    }
    private void SpawnProjectiles() {
        spawnProjectilesTimer = Time.time + spawnProjectilesTimerDelay;
        GameObject projectile = GameObject.Instantiate(objectToBeSpawned, transform.position, objectToBeSpawned.transform.rotation) as GameObject;
        projectile.transform.Rotate(0, 0, transform.localEulerAngles.z);
        projectileCount++;
    }
    private bool ShouldRotate() {
        return Time.time >= rotateTimer;
    }




}
