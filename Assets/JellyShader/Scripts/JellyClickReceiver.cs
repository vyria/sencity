using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyClickReceiver : MonoBehaviour {
    private RaycastHit hit;
    private Ray clickRay;
    private Renderer modelRenderer;
    private float controlTime;

    // Use this for initialization
    private void Start () {
        modelRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    private void Update () {
        controlTime += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(clickRay, out hit))
            {
                controlTime = 0;

                modelRenderer.material.SetVector("_ModelOrigin", transform.position);
                modelRenderer.material.SetVector("_ImpactOrigin", hit.point);
            }
        }

        modelRenderer.material.SetFloat("_ControlTime", controlTime);
	}
}
