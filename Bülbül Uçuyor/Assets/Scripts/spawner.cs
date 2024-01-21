using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public Bird_Jump Birdscirpts;
    public GameObject Borular;
    public float height;
    public float time;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    IEnumerator SpawnObject(float time)
    {
        while(!Birdscirpts.isDead)
        {

            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(1F);
            


        }
    }
}
