using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltar : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Saltando", true);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("Voltereta", true);
        }
    }
    void End ()
    {
        animator.SetBool("Saltando", false);
    }
    void Endv()
    {
        animator.SetBool("Voltereta", false);
    }
}
