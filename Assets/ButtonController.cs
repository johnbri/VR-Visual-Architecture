using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonController : MonoBehaviour
{
    public Button yourButton;
    public GameObject boll;
    void Start()
    {
        Console.WriteLine("This is C#");
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        boll.SetActive(false);
        Console.WriteLine("Click");
        Debug.Log("You have clicked the button!");
    }
}
