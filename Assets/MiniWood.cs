using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniWood : MonoBehaviour
{

    public GameObject MyButton;
    public GameObject MyButton1;
    public GameObject MyButton2;
    public GameObject MyButton3;
    Button button;
    Button button1;
    Button button2;
    Button button3;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("q"))
        {
            button = MyButton.GetComponent<Button>();
            button.interactable = false;
        }

        if (Input.GetKeyDown("w"))
        {
            button1 = MyButton1.GetComponent<Button>();
            button1.interactable = false;
        }

        if (Input.GetKeyDown("e"))
        {
            button2 = MyButton2.GetComponent<Button>();
            button2.interactable = false;
        }

        if (Input.GetKeyDown("r"))
        {
            button3 = MyButton3.GetComponent<Button>();
            button3.interactable = false;
        }

        AddResource();
    }

    void AddResource()
    {
        button = MyButton.GetComponent<Button>();
        button1 = MyButton1.GetComponent<Button>();
        button2 = MyButton2.GetComponent<Button>();
        button3 = MyButton3.GetComponent<Button>();

        if (button.interactable == false && button1.interactable == false && button2.interactable == false && button3.interactable == false)
        {
            button.interactable = true;
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
        }
    }

}
   

