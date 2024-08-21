using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;
using Cinemachine;

public class SpawnPrefabR : MonoBehaviour
{
public GameObject[] myPrefabs;
   
public int prefabIndex ;
//private Vector3 spawnPos = new Vector3(103, 0.435f, -192);
private Vector3 spawnPos;
private Vector3 playerPos;
public GameObject myPlayer;

public PlayerControllerR playerCtrScript; 

    
    void Start()
    {
          RepeateInstantiating();
          playerCtrScript = GameObject.Find("MyRunner").GetComponent<PlayerControllerR>();
          playerPos = myPlayer.transform.position ;
          spawnPos = playerPos;
          
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
