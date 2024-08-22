using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class PlayerControllerR : MonoBehaviour
{
    private  Rigidbody playerRb;
    public float jumpSpeed = 10.0f;
    public float moveSpeed = 5f; 
    public bool isOnGround = true;
    public bool gameOver;
    public ParticleSystem explosionPS ; 
    public ParticleSystem dirtPS ; 
    public AudioClip jumpSFX; 
    public AudioClip crashSFX ; 
    private AudioSource playerAudio ; 
   
    private Animator playerAnim; 
     


    void Start()
    {
        playerRb = GetComponent<Rigidbody>() ;
        playerAnim = GetComponent<Animator>() ;
        playerAudio = GetComponent<AudioSource>(); 
        
    }

    void Update()
    {
         if(Input.GetKey(KeyCode.RightArrow) && gameOver == false)
         {
           
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime) ;
            playerAnim.SetBool("Run_b", true) ;
            playerAnim.SetBool("Idle_b", false) ;   
         }

         else if (Input.GetKeyUp(KeyCode.RightArrow))
         {
            playerAnim.SetBool("Idle_b", true) ;
         
         }

        ////left move control block
         if(Input.GetKey(KeyCode.LeftArrow) && gameOver == false)
         {  
          
            transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime) ;
            playerAnim.SetBool("Run_b", true) ;
            playerAnim.SetBool("Idle_b", false) ;   
         }

         else if (Input.GetKeyUp(KeyCode.LeftArrow))
         {
            playerAnim.SetBool("Idle_b", true) ;
         
         }
        /////end
     

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && gameOver != true)
        {      
            
               playerRb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse); 
               isOnGround = false; 
              // playerAnim.SetTrigger("Jump_trig") ;
               StopPlayingParticles();
               playerAudio.PlayOneShot(jumpSFX, 1.0f); 
        }
    }

 private void OnCollisionEnter(Collision collision) 
    { 
       
        if(collision.gameObject.CompareTag("Ground"))
        {
              isOnGround = true;
               
        }
        
   if(collision.gameObject.CompareTag("Obstacle"))
        { 
            Debug.Log("Game Over!");
            explosionPS.Play() ;
            playerAnim.SetTrigger("Die_trig") ;
            playerAudio.PlayOneShot(crashSFX, 1.0f); 
            gameOver = true;
            
        }

    }
    public void StopPlayingParticles()
    {
      dirtPS.Stop() ; 
    }

    public void PlayingParticles()
    {
        dirtPS.Play() ; 
        
    }

    }

