using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAway : MonoBehaviour
{
    public SpriteRenderer sr1;
    public SpriteRenderer sr2;



    private void trnsprncyDecreacing()
    {
        if (sr1.color.a >= 0)
        {
            float ActualAlpha = sr1.color.a;
            sr1.color = new Color(255, 255, 255, ActualAlpha - .1f);
            sr2.color = new Color(255, 255, 255, ActualAlpha - .1f);
        }
        else
            AutoDestruction();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Hoop hitted");
        if (collision.gameObject.tag == "Player")
        {
            InvokeRepeating("trnsprncyDecreacing", 0.4f, 0.1f);
        }
    }

    private void AutoDestruction()
    {
        Destroy(this.gameObject);
    }
}
