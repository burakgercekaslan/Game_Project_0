using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOve : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        Destroy(gameObject, 4);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
