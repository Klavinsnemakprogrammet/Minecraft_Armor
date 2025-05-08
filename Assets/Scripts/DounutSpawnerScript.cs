using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class DounutSpawnerScript : MonoBehaviour
{
    public GameObject[] dounutPrefabs;
    public float spawnInterval = 1f;
    float minPoz, maxPoz;
    Transform ovenPozition;
    private void Start()
    {
        ovenPozition = GetComponent<Transform>();

    }
    public void BakeDounut(bool state)
    {
        if (state)
            StartCoroutine(BakeDounut());
        else 
            StopAllCoroutines();

    }
    IEnumerator BakeDounut()
    {
        while(true)
        {
            minPoz = ovenPozition.position.x-30f;
            maxPoz = ovenPozition.position.x + 30f;
            float randomX = Random.Range(minPoz, maxPoz);
            Vector2 spawnPosition =
                new Vector2(randomX, ovenPozition.position.y);
            GameObject dounut =
                Instantiate(dounutPrefabs[Random.Range(0, dounutPrefabs.Length)],spawnPosition, 
                Quaternion.identity, ovenPozition);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

}
