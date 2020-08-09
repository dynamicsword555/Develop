using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatGoalScript3 : MonoBehaviour
{
    Text text;
    GameObject obj;
    GameObject obj1;
    GameObject obj2;
    GameObject obj3;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("MessageText");
        text = obj.GetComponent<Text>();
        obj1 = GameObject.Find("cat_Walk1");
        obj2 = GameObject.Find("cat_Walk2");
        obj3 = GameObject.Find("cat_Walk3");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            text.text = "一着は3レーンの猫です";
            if (text.text.Length > 0)
            {
                obj1.GetComponent<CatRaceScript>().enabled = false;
                obj2.GetComponent<CatRaceScript>().enabled = false;
                obj3.GetComponent<CatRaceScript>().enabled = false;

            }
        }
    }
}
