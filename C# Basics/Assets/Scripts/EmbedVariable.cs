using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmbedVariable : MonoBehaviour
{

    string[] sports = { "サッカー", "テニス", "バスケ" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sports[0]);

        Debug.Log(sports.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
