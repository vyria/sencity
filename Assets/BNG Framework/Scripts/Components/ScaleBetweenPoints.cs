using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BNG {

    /// <summary>
    /// Scales an object's local Z scale to match a Begin / End point
    /// </summary>
    public class ScaleBetweenPoints : MonoBehaviour {

        public Transform Begin;
        public Transform End;

        public bool DoUpdate = true;
        public bool DoLateUpdate = false;

        public bool LookAtTarget = false;

        private void Update() {
            if(DoUpdate) {
                doScale();
            }
        }

        private void LateUpdate() {
            if (DoLateUpdate) {
                doScale();
            }
        }

        private void doScale() {

            if(LookAtTarget) {
                transform.position = Begin.position;
                transform.LookAt(End, transform.up);
            }

            Vector3 objectScale = transform.localScale;
            float distance = Vector3.Distance(Begin.position, End.position);

            Vector3 newScale = new Vector3(objectScale.x, objectScale.y, distance);
            transform.localScale = newScale;
            transform.position = (Begin.position + End.position) / 2;
        }
    }
}
