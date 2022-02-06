using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EmbedVariable : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int number = 290;

        if (number == 10)
        {
            Debug.Log(10);
        }
        else if (number == 30)
        {
            Debug.Log(30);
        }
        else
        {
            Debug.Log("それ以外");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
