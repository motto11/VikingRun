using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chaser : MonoBehaviour
{
    public GameObject player;
    public int MoveSpeed = 4;
    public static float startTime;
    

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
}
