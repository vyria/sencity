using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNG {

    public class ScaleMaterialHelper : MonoBehaviour {
        private Renderer ren;

        public Vector2 Tiling = new Vector2(1,1);
        public Vector2 Offset;

        // Start is called before the first frame update
        private void Start() {
            ren = GetComponent<Renderer>();
            updateTexture();
        }

        private void updateTexture() {
            if(ren != null && ren.material != null) {
                ren.material.mainTextureScale = Tiling;
                ren.material.mainTextureOffset = Offset;
            }
        }

        // Update live in editor / selected
        private void OnDrawGizmosSelected() {
            if (Application.isEditor) {
                updateTexture();
            }
        }
    }
}

