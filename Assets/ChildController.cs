using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildController : MonoBehaviour {

    public GameObject m_textHunger;
    public GameObject m_textCold;
    public GameObject m_textDanger;

    public float m_hunger = 0.0f;
    public float m_hungerSpeed = 1.0f;
    public float m_cold = 0.0f;
    public float m_coldSpeed = 1.0f;
    public float m_danger = 0.0f;
    public float m_dangerSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        m_hunger += m_hungerSpeed * Time.deltaTime;
        m_textHunger.GetComponent<Text>().text = "";

        m_cold += m_coldSpeed * Time.deltaTime;
        m_danger += m_dangerSpeed * Time.deltaTime;
    }
}
