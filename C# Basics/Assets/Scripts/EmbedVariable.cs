using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster
{
    public string kind = "モンスター";

    public void bodyBlow()
    {
        Debug.Log("体当たり");
    }
}

class Dragon : Monster
{
    public void fireBreath()
    {
        Debug.Log("火の息を吐く");
    }
}

class Sline : Monster
{
    public void recovery()
    {
        Debug.Log("回復する");
    }
}


public class EmbedVariable : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Dragon dragon = new Dragon();
        Debug.Log(dragon.kind);
        dragon.bodyBlow();
        dragon.fireBreath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
