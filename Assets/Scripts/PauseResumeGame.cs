using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResumeGame : MonoBehaviour
{
    [SerializeField] GameObject camera;
    [SerializeField] GameObject canvas;
    
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        bool currentStateCam=camera.activeSelf;
        bool currentStateCanv=canvas.activeSelf;
        if(currentStateCam)
        {
            Time.timeScale=1f;
            GameObject parent=GameObject.Find("Car(Clone)");
            GameObject child=parent.transform.GetChild(2).gameObject;
            GameObject grandchild1=child.transform.GetChild(4).gameObject;
            GameObject grandchild2=child.transform.GetChild(5).gameObject;
            grandchild1.GetComponent<AudioSource>().Play();
            grandchild2.GetComponent<AudioSource>().Play();
        }
        else
        {
            Time.timeScale=0f;
            GameObject parent=GameObject.Find("Car(Clone)");
            GameObject child=parent.transform.GetChild(2).gameObject;
            GameObject grandchild1=child.transform.GetChild(4).gameObject;
            GameObject grandchild2=child.transform.GetChild(5).gameObject;
            grandchild1.GetComponent<AudioSource>().Stop();
            grandchild2.GetComponent<AudioSource>().Stop();
        }
        camera.SetActive(!currentStateCam);
        canvas.SetActive(!currentStateCanv);
    }
}
