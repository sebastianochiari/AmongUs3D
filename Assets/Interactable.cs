using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject uiObject;

    void Start() {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider player) {
        if (player.gameObject.tag == "Player") {
            uiObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider player) {
        if(player.gameObject.tag == "Player") {
            uiObject.SetActive(false);
        }
    }
}
