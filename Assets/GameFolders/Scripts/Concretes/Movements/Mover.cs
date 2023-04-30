using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFolders.Scripts.Concretes.Movements
{
    public class Mover
    {
        private Rigidbody _rigidbody;

        public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * (Time.deltaTime * 55f));
        }
    }
}

