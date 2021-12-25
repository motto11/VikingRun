using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour, IPointerClickHandler
{
    public int SceneIndexDestination;

    public void OnPointerClick(PointerEventData e)
    {
        Generator.direction = 0;
        Generator.x = 0;
        Generator.z = 8;
        CoinBehaviourScript.count = 0;
        Chaser.startTime = Time.time;
        SceneManager.LoadScene(SceneIndexDestination);
    }
}
