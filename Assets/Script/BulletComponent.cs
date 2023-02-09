using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Pool;

public class BulletComponent : MonoBehaviour
{
    Rigidbody b_rigidbody;
    public GameObject objectToSpawn;
    public float force = 3;

    // ObjectPool objectPool = new ObjectPool<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        b_rigidbody = GetComponent<Rigidbody>();
        Instantiate(objectToSpawn);
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
    }

    void SpawnObject(){
        GameObject newObject = Instantiate(objectToSpawn);
    }

    GameObject OnObjectCreate(){
        GameObject newObject = Instantiate(objectToSpawn);
        // newObject.AddComponent<PoolObject>().myPool = objectPool;
        return newObject;
    }

    void OnTake(GameObject poolObject){
        poolObject.SetActive(true);
    }

    void OnRelease(GameObject poolObject){
        poolObject.SetActive(false);
    }

    void OnObjectDestroy(GameObject poolObject){
        Destroy(poolObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
