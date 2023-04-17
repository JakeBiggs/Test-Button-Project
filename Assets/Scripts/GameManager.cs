using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static float gameSpeed = 10;

    public Transform spawnPoint;
    public float timeBetweenSpawns = 1;

    public List<GameObject> beatObjects = new List<GameObject>();

    private void Awake(){
        StartCoroutine(GameLoop());
    }

    private IEnumerator GameLoop()
    {
        while(true)
        {
            GameObject newBeat = beatObjects[Random.Range(0, beatObjects.Count)];
            GameObject clone = Instantiate(newBeat, spawnPoint.position, spawnPoint.rotation);

            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
}
