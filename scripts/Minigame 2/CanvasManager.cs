using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public Canvas canvasBackground;
    public void DisableCanvas(){
        canvasBackground.enabled = false;

            foreach (Transform child in canvasBackground.transform) {
                child.gameObject.SetActive(false);
            }
            StartCoroutine(BackgroundTimer());
    }

    IEnumerator BackgroundTimer(){
        yield return new WaitForSeconds(5.1f);

        canvasBackground.enabled = true;

        foreach (Transform child in canvasBackground.transform) {
            child.gameObject.SetActive(true);
        }
    }
}
