using System;
using GameFolders.Scripts.Abstracts.Controllers;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] private Vector3 direction;
        [SerializeField] private float time;
        
        private Vector3 _startPosition;
        private float _factor;
        private const float FULL_CIRCLE = Mathf.PI * 2f;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / time;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);

            _factor = Mathf.Abs(sinWave); 
            
            Vector3 offset = direction * _factor;
            transform.position = offset + _startPosition;
        }
    }
}

