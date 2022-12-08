using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer line;
    private Transform[] points;

    // Start is called before the first frame update
    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    public void SetUpLine(Transform[] points){
        line.positionCount = points.Length;
        this.points = points;
        }

    // Update is called once per frame
    void Update()
    {
        if (points.Length > 0 && points.Length != null){
            for (int i = 0; i < points.Length; i++) {
                line.SetPosition(i, points[i].position);
            }   
        }
     
    }
}

