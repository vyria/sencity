using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BNG {
    public class RagdollHelper : MonoBehaviour {
        private Transform player;
        private List<Collider> colliders;
        private Collider playerCol;

        // Start is called before the first frame update
        private void Start() {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            playerCol = player.GetComponentInChildren<Collider>();

            colliders = GetComponentsInChildren<Collider>().ToList();

            foreach(var col in colliders) {
                Physics.IgnoreCollision(col, playerCol, true);
            }
        }
    }
}

