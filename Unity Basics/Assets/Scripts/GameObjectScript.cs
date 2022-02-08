using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera camera = gameObject.gameObject.GetComponent<Camera>();

        camera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
