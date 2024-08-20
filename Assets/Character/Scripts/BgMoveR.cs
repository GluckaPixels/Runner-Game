using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMoveR : MonoBehaviour
{
   
    public float speedLeft = -2.5f; 
    private PlayerControllerR plCtrr;
   
    void Start()
    {
        plCtrr = GameObject. Find("Player").GetComponent<PlayerControllerR>() ; 
        
    }

  
    void Update()

    {   
        if(plCtrr.gameOver == false)
        {
            transform.Translate(Vector3.left * speedLeft  * Time.deltaTime );
       
        }
       
       
    }
}
