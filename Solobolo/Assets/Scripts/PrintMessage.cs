using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// I do not know what that does. Something like documentation. :D
/// </summary>
public class PrintMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const int MaxScore = 100;
        int score = 40;
        float percent = (float) score / MaxScore;
        Debug.Log(percent);
    }
}