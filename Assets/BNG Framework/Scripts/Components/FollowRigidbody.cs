using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNG {
    public class FollowRigidbody : MonoBehaviour {

        public Transform FollowTransform;
        private Rigidbody rigid;

        private void Start() {
            rigid = GetComponent<Rigidbody>();
        }

        private void FixedUpdate() {
            rigid.MovePosition(FollowTransform.transform.position);
        }
    }
}

