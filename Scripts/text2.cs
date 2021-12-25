using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text2 : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = $"Time: {(int)(Time.time - Chaser.startTime)} seconds";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
