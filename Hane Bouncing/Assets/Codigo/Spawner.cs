using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float timeLapseToSpawn;
    public float RangoX1;
    public float RangoX2;

    private float timeToSpawn = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn += Time.deltaTime;
        if (timeToSpawn > timeLapseToSpawn)
        {
            Instantiate(prefab, Vector3Random(), prefab.gameObject.transform.rotation);
            timeToSpawn = 0;
        }
    }


    private Vector3 Vector3Random()
    {
        float x = Random.Range(RangoX1, RangoX2);       
        return new Vector3(x, 7, 0);
    }

}
