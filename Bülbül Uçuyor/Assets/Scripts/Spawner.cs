using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BothColumns;
    public GameObject TopColumn;
    public GameObject BottomColumn;
    public Bird_Jump birdsc;
    private float height = 8;
    private float random;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    // Update is called once per frame
    public IEnumerator SpawnObject(float time)
    {
        while (!birdsc.isdead)
        {
            random = Random.Range(0,100);
            if (random < 50) { 
           
            Instantiate(BothColumns, new Vector3(-20, Random.Range(height-14, height-12),0), Quaternion.identity);
            yield return new WaitForSeconds(time);
            }
            else if (random < 75)
            {
                Instantiate(TopColumn, new Vector3(5, Random.Range(height-4, height-2), 0), Quaternion.identity);
                yield return new WaitForSeconds(time);
            }
            else
            {
                Instantiate(BottomColumn, new Vector3(5, Random.Range(height-11, height-9), 0), Quaternion.identity);
                yield return new WaitForSeconds(time);
            }
        }
    }
}
