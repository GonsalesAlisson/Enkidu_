using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogControl : MonoBehaviour
{
    public static DialogControl instance;
	void Awake(){
		if(instance!=null){
			Debug.LogError("Mais de um DialogControl");
			return;
		}

		instance = this;
	}
	public Image panel;
	public Text text;
    void Start()
    {
        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showMessage(string message){
    	panel.gameObject.SetActive(true);
    	text.text = message;
    }
}
