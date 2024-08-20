using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;

public class SpawnPrefabR : MonoBehaviour
{
public GameObject[] myPrefabs;
   
public int prefabIndex ;
private Vector3 spawnPos = new Vector3(151, 16, -192);

public PlayerControllerR playerCtrScript; 

    
    void Start()
    {
          RepeateInstantiating();
          playerCtrScript = GameObject.Find("MyRunner").GetComponent<PlayerControllerR>();       
    }
    void InstantiatePrefab()
    {    
       
        prefabIndex = UnityEngine.Random.Range(0, myPrefabs.Length);

        if(playerCtrScript.gameOver == false)
        {
            Instantiate(myPrefabs[prefabIndex], spawnPos, myPrefabs[prefabIndex].transform.rotation) ;
        }
       
    }
    public void RepeateInstantiating()
    {   
        
         InvokeRepeating("InstantiatePrefab",2f,4f);
        
    }

}
