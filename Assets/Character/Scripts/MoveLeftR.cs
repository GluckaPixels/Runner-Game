using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftR : MonoBehaviour
{
     public float speedLeft = -2.5f; 
    private float posBounds = 25.0f;

   public PlayerControllerR playerCtrScript; 
   
    void Start()
    {
        playerCtrScript = GameObject.Find("MyRunner").GetComponent<PlayerControllerR>(); 
    }

  
    void Update()

    {   

        if(playerCtrScript.gameOver == false)
        {  
          transform.Translate(Vector3.left * speedLeft  * Time.deltaTime );
        }

     

        //if(transform.position.x > posBounds){
            //Destroy(gameObject);
        //}
    }
}
