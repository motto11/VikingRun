using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = $"Coin: {CoinBehaviourScript.count}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
