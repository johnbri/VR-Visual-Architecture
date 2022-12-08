using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightController : MonoBehaviour
{
    private LineRenderer highlight;
    private Transform[] points;
    private GameObject obj;
    // Start is called before the first frame update
    void Awake()
    {
        //highlight = GetComponent<LineRenderer>();
    }

    public void SetUpLine(Transform[] points){
        obj = Instantiate(gameObject);
        highlight = obj.GetComponent<LineRenderer>();
        highlight.positionCount = points.Length;
        this.points = points;
        for (int i = 0; i < points.Length; i++) {
            highlight.SetPosition(i, points[i].position);
        
        } 
        
        }

    // Update is called once per frame
    void Update(){   
         
    }
}
