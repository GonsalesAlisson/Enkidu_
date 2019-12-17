using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enkidu : MonoBehaviour
{
    public float hSpeed;
    public Animator myAnimator;
    public Renderer rend;
    float m_Horizontal;
    bool isRight;

    void Start()
    {
        isRight = true;
    }

    // Update is called once per frame
    void Update()
    {
    	m_Horizontal = Input.GetAxis("Horizontal");
        hSpeed = m_Horizontal*Time.deltaTime * 7.0f;
        if(m_Horizontal<0){
        	 if(isRight){
       		 	transform.localScale = new Vector3(transform.localScale.x *-1, transform.localScale.y, transform.localScale.z);
       		 	isRight = false;
       		 }
        }
       	else if(m_Horizontal>0){
       		 if(!isRight){
       		 	transform.localScale = new Vector3(transform.localScale.x*-1 , transform.localScale.y, transform.localScale.z);
       		 	isRight = true;
       		 }
       	}
        this.transform.Translate(hSpeed,0,0);
        myAnimator.SetFloat("hSpeed",System.Math.Abs(hSpeed));




        }
    }

