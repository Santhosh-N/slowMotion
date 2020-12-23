using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{

    public float slowTime = 0.2f;
    private bool isSlowed = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (isSlowed)
            {
                isSlowed = false;
                Time.timeScale = 1;
                Time.fixedDeltaTime = Time.deltaTime;
            }
            else
            {
                isSlowed = true;
                Time.timeScale = slowTime;
                Time.fixedDeltaTime = slowTime * Time.deltaTime;
            }
        }
    }
}
