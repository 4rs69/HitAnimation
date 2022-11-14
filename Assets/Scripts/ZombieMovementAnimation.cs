using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovementAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var vertical = Input.GetAxis("Vertical"); 
        
        if (vertical == 0)
        {
            _animator.SetBool("Walking",false);
            _animator.SetBool("Walking Back",false);
        }
        
        if (vertical >= 0.1f)
        {
            _animator.SetBool("Walking",true);
        }
        
        if (vertical <= -0.1f)
        {
            _animator.SetBool("Walking Back",true);
        }
        
        
        
    }
}
