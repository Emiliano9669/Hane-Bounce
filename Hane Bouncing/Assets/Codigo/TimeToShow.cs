using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeToShow : MonoBehaviour
{
    public Text txt;
    private float time;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        txt.text = time.ToString("0");
    }


}
