using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviourScript : MonoBehaviour
{
    public static int count = 0;
    private void OnTriggerEnter(Collider other)
    {
        count++;
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
