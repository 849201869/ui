using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitgame : MonoBehaviour {
    public GameObject message;
    private GameObject amessage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
                if (amessage == null)
                {
                    Debug.Log("0");
                    amessage = Instantiate<GameObject>(message);
                    amessage.transform.SetParent(this.gameObject.transform);
                    amessage.GetComponent<RectTransform>().localPosition =new Vector3(0,-300,100);
                    amessage.GetComponent<RectTransform>().localScale = Vector3.one;
                StartCoroutine(ResetQuitMessage());
                }
        
            else
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
            }
        }
	}

    IEnumerator ResetQuitMessage()
    {
        yield return new WaitForSeconds(1f);
        if (amessage!=null)
        {
            Destroy(amessage);
            
        }
    }
}
