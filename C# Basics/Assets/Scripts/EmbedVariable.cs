using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Animal
{
    public int age = 2;
    public string kind = "犬";

    public void Bite()
    {
        Debug.Log($"{age}才の{kind}が噛み付く");
    }

}

public class EmbedVariable : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        Animal dog = new Animal();

        Debug.Log(dog.kind);
        dog.Bite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
