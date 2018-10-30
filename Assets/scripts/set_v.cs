using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class set_v : MonoBehaviour {
    public Animator set_vo;
    public GameObject set_vl;
    public GameObject menu;
    public Animator ani_window;
    public void set_vopen()
    {
        set_vl.SetActive(true);
        set_vo.SetBool("set_v", true);
        ani_window.SetBool("menu_in", false);
        ani_window.SetBool("menu_out", true);
    }
    public void set_vclose()
    {
        set_vo.SetBool("set_v", false);
        set_vl.SetActive(false);
        ani_window.SetBool("menu_out", false);
        ani_window.SetBool("menu_in", true);
    }

}
