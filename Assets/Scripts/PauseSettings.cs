using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSettings : MonoBehaviour
{
    [SerializeField] GameObject camera;
    [SerializeField] GameObject canvas;

    public void NavigationMenu()
    {
        SceneManager.LoadScene("Navigation Menu");
        Time.timeScale=1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene("FreeRoam");
        Time.timeScale=1f;
    }

    public void Resume()
    {
        bool currentStateCam=camera.activeSelf;
        bool currentStateCanv=canvas.activeSelf;
        GameObject parent=GameObject.Find("Car(Clone)");
        GameObject child=parent.transform.GetChild(2).gameObject;
        GameObject grandchild1=child.transform.GetChild(4).gameObject;
        GameObject grandchild2=child.transform.GetChild(5).gameObject;
        grandchild1.GetComponent<AudioSource>().Play();
        grandchild2.GetComponent<AudioSource>().Play();
        camera.SetActive(!currentStateCam);
        canvas.SetActive(!currentStateCanv);
        Time.timeScale=1f;
    }

}
