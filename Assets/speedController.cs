using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class speedController : MonoBehaviour {

    public InputField field;
    static public float q;
    public Button but;
    string w;

	// Use this for initialization
	void Start () {
        SpeedVar();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void OnClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void SpeedVar()
    {
        string w = field.text;
        float q = float.Parse(w);
        Debug.Log(q);
    }
}
