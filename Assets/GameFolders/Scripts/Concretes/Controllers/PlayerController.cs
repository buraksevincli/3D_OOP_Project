using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
    }
}

