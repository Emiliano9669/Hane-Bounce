using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public Transform pos;
    public Text adminReference;
    public float timeLapseToSpawn;

    private float timeToSpawn = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn += Time.deltaTime;
        adminReference.text = timeToSpawn.ToString("0");
        if (timeToSpawn > timeLapseToSpawn)
        {
            print("spawneamos!");
            Instantiate(prefab, Vector3Random(), prefab.gameObject.transform.rotation);
            timeToSpawn = 0;
        }
    }


    private Vector3 Vector3Random()
    {
        float x = Random.Range(-2.2f, 2.2f);       
        return new Vector3(x, 7, 0);
    }

}
