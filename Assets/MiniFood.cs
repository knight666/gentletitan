using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniFood : MonoBehaviour
{

    public GameObject MyButton;
    public GameObject MyButton1;
    public GameObject MyButton2;
    public GameObject MyButton3;
    Button button;
    Button button1;
    Button button2;
    Button button3;
    bool activeCheck = true;
    public Text text;

    public GameObject Titan;



    // Use this for initialization
    void Start()
    {
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("p"))
        {
            button = MyButton.GetComponent<Button>();
            button.interactable = false;
        }

        if (Input.GetKeyDown("o"))
        {
            button1 = MyButton1.GetComponent<Button>();
            button1.interactable = false;
        }

        if (Input.GetKeyDown("i"))
        {
            button2 = MyButton2.GetComponent<Button>();
            button2.interactable = false;
        }

        if (Input.GetKeyDown("u"))
        {
            button3 = MyButton3.GetComponent<Button>();
            button3.interactable = false;
        }

        if (activeCheck == true)
        {
            AddResource();
        }

    }

    void AddResource()
    {
        button = MyButton.GetComponent<Button>();
        button1 = MyButton1.GetComponent<Button>();
        button2 = MyButton2.GetComponent<Button>();
        button3 = MyButton3.GetComponent<Button>();



        if (button.interactable == false && button1.interactable == false && button2.interactable == false && button3.interactable == false)
        {
            activeCheck = false;
            //modify wood amount on titan
            Titan.GetComponent<TitanController>().m_food += 1;

            StartCoroutine(ShowMessage("+1 Food", 1));

        }
    }


    IEnumerator ShowMessage(string message, float delay)
    {

        text.text = message;
        text.enabled = true;
        yield return new WaitForSeconds(delay);
        text.enabled = false;

        button.interactable = true;
        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = true;

        activeCheck = true;
    }


}


