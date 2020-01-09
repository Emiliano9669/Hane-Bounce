using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoLatigo : MonoBehaviour
{

    GameObject colisionador;

    // Start is called before the first frame update
    void Start()
    {
        print("z actual: " + transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -9);
            print("z cambiada? : " + transform.position.z);
        }
    }

}
