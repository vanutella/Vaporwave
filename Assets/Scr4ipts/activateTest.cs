using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateTest : MonoBehaviour {
    public GameObject Mitte1;
    public GameObject Mitte2;
    public GameObject Mitte3;

    public GameObject Rahmen1;
    public GameObject Rahmen2;
    public GameObject Rahmen3;

    public GameObject Banner1;
    public GameObject Banner2;
    public GameObject Banner3;

    public GameObject ranLi1;
    public GameObject ranLi2;
    public GameObject ranLi3;

    public GameObject ranRe1;
    public GameObject ranRe2;
    public GameObject ranRe3;


    // Use this for initialization
    void Start () {
        Mitte1.SetActive(false);
        Mitte2.SetActive(false);
        Mitte3.SetActive(false);
        Rahmen1.SetActive(false);
        Rahmen2.SetActive(false);
        Rahmen3.SetActive(false);
        Banner1.SetActive(false);
        Banner2.SetActive(false);
        Banner3.SetActive(false);
        ranLi1.SetActive(false);
        ranLi2.SetActive(false);
        ranLi3.SetActive(false);
        ranRe1.SetActive(false);
        ranRe2.SetActive(false);
        ranRe3.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Mitte1.SetActive(true);
            Rahmen1.SetActive(true);
            Banner1.SetActive(true);
            ranLi1.SetActive(true);
            ranRe1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Mitte2.SetActive(true);
            Rahmen2.SetActive(true);
            Banner2.SetActive(true);
            ranLi2.SetActive(true);
            ranRe2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Mitte3.SetActive(true);
            Rahmen3.SetActive(true);
            Banner3.SetActive(true);
            ranLi3.SetActive(true);
            ranRe3.SetActive(true);
        }
    }
}
