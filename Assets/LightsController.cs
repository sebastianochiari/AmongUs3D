using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour
{

    public bool lightsAreOn = true;

    private GameObject point_light;
    private GameObject[] lights;

    void Start() {
        lights = GameObject.FindGameObjectsWithTag("White Lights");
    }

    void Update() {
        if(Input.GetKeyDown("1")) {
            setLights();
        }
    }

    public void setLights() {

        if(lightsAreOn == true) {
            lightsAreOn = false;
            turnLights(lightsAreOn);
        } else {
            lightsAreOn = true;
            turnLights(lightsAreOn);
        }

    }

    void turnLights(bool boolean) {
        foreach (GameObject light in lights) {
            point_light = light.transform.GetChild(0).gameObject;
            point_light.SetActive(boolean);
        }
    }
}
