using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{

    public float limitLifePosition;
    public float speed;
    public Vector3 direction;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direction * Time.deltaTime * speed);
        if (this.transform.position.y < limitLifePosition)
        {
            Destroy(this.gameObject);
        }
    }
}
