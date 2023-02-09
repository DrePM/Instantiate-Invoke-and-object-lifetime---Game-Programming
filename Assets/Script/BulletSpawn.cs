using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    Rigidbody s_rigidbody;
    public GameObject spawnPoint;
    public GameObject projectile;
    public float launchForce = 5000f;

        // private float nextFire = 0.5f;
        // private GameObject newProjectile;
        // private float myTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
      s_rigidbody = GetComponent<Rigidbody>();
      spawnPoint = GameObject.FindGameObjectWithTag("glock");  
    }

    public void SpawnPoint(){
        transform.position = spawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // myTime = myTime + Time.deltaTime;

        if(Input.GetButtonDown("Fire1")){
            // nextFire = myTime + launchForce;
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchForce, 0));

            // nextFire = nextFire - myTime;
            // myTime = 0.0f;
        }
    }
}
