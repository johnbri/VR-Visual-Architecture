using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonController : MonoBehaviour
{
    public Button yourButton;
    
    [SerializeField] public Material highlightMat;
    [SerializeField] public Material plainMat;
    [SerializeField] public LineRenderer line1;
    [SerializeField] public LineRenderer line2;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        line1.GetComponent<Renderer>().material = highlightMat;
        line2.GetComponent<Renderer>().material = plainMat;
        
    }
}
