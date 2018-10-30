using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour {

    public Canvas c1;
    public Canvas c2;
    public void changecan()
    {
        c1.gameObject.SetActive(true);
        c2.gameObject.SetActive(false);
    }
    public void changecanli()
    {
        c1.gameObject.SetActive(false);
        c2.gameObject.SetActive(true);


    }
}
