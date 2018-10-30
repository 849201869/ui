using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class text_start : MonoBehaviour,IPointerClickHandler {
    public Animator ani_window;
    public Animator ani_text;
    public GameObject textspace;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            Debug.Log("1");

            ani_text.SetBool("text_in", false);
            textspace.SetActive(false);
            ani_window.SetBool("menu_out", false);
            ani_window.SetBool("menu_in", true);
        }
        //OnPointerClick(PointerEventData eventData);
	}

    public void text_startanim()
    {
        textspace.SetActive(true);
        ani_window.SetBool("menu_in", false);
        ani_window.SetBool("menu_out", true);
        ani_text.SetBool("text_in", true);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10f);

        ani_text.SetBool("text_in", false);
        textspace.SetActive(false);
        ani_window.SetBool("menu_out", false);
        ani_window.SetBool("menu_in", true);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying=false;
#else
        Application.Quit();
#endif
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("1");

        //ani_text.SetBool("text_in", false);
        //textspace.SetActive(false);
        //ani_window.SetBool("menu_out", false);
        //ani_window.SetBool("menu_in", true);
    }
}
