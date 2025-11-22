using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
public class movement : MonoBehaviour
{
    public Animator animator;
    public float inputx;
    public float inputy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.GetAxis("Horizontal");
        inputy = Input.GetAxis("Vertical");
        animator.SetFloat("inputx", inputx);
        animator.SetFloat("inputy", inputy);
    }
}
