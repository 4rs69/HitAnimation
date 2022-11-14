using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class UnpredictableBeats : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

   
    private static readonly int RandomHit = Animator.StringToHash("RandomHit");


    private void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetTrigger("Hit");
            _animator.SetFloat(RandomHit,Random.value);
        }




    }
}
