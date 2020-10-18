using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public new bool enabled;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
        animator.SetBool("enabled", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Enabled()
    {
        animator.SetBool("enabled", true);
    }
}
