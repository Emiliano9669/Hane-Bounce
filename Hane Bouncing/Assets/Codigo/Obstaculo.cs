using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{

    public int speed;
    public float limitLifePositionY;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (this.transform.position.y < limitLifePositionY)
        {
            Destroy(this.gameObject);
        }
    }
}
