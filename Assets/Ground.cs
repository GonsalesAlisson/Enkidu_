using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    DialogControl dialog;
    void Start()
    {
        dialog = DialogControl.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col){
    	dialog.showMessage("Enkidu, meu irmão. Vamos nos aventurar enquanto sonhas mais uma vez");
    }
}
