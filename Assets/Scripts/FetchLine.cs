using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchLine : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private LineController line;
    [SerializeField] private HighlightController highlight;

    // Start is called before the first frame update
    void Start()
    {
        line.SetUpLine(points);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            OnClicked();
        }
    }

    void OnClicked(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
 
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Clicked on " + hit.transform.name);
            Debug.Log(" hit");
            highlight.SetUpLine(points);
        } 
        else 
        {
            Debug.Log("Nothing hit");
        }
   }
}
