using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundR : MonoBehaviour
{
   private Vector3 bgStartPos; 
    private float repeatWidth; 

    //private PlayerController playerCtrlScript; 
   
    void Start() 
    {
        bgStartPos = transform.position ;
        //playerCtrlScript = GameObject. Find("Player").GetComponent<PlayerController>() ;
        //repeatWidth = gameObject. GetComponent<BoxCollider>().size.x/ 0.4f ;
    }

    // Update is called once per frame
    void Update()
    {
       
           if (transform.position.x > bgStartPos.x + repeatWidth + 80)
        {
            transform.position = bgStartPos; 
           
        }
        
        
    }
}
