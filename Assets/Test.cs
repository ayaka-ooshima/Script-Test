using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //
        int[] array = { 50, 40, 30, 20, 10 };

        //
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //
        for (int i = array.Length - 1; i >= 0; i--)
        {
            //
            Debug.Log(array[i]);

            //
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}