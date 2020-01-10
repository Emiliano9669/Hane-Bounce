using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{

    public GameObject background;



    public void SpawnBackground()
    {
        Instantiate(background, new Vector3(0,10,10), background.gameObject.transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("hubo un trigger");
        if (collision.gameObject.tag == "background")
        {
            print("background hits");
            SpawnBackground();
        }
    }

}
