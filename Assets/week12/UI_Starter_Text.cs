using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Text : MonoBehaviour
{
    public GameObject MyGameObject;
    void Start()
    {
        string name = MyGameObject.name; //this case, Cube
        name += " made by hyun ohhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh";
        GetComponent<Text>().text = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
