using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject rearView;
    public GameObject sideView;
    public GameObject wheelView;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = rearView.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            this.transform.position = sideView.transform.position;
        }
        else if(Input.GetMouseButton(0))
        {
            this.transform.position = wheelView.transform.position;
        }
        else
        {
            this.transform.position = rearView.transform.position;
        }

    }
}
