using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour {
    //Textures that correspond to x, o and plain
    public Texture plain;
    public Texture cross;
    public Texture circle;
    private bool player;
    private int steps;
    public GameObject btn;
    [SerializeField]
    private Text textField = null;
    private void Start()
    {
        btn = GameObject.Find("Button");
    }

    void OnMouseDown()
    {
        
        player = this.transform.parent.transform.parent.GetComponent<BoardSpecific>().turn;
        if (player==true)
        { 
            GetComponent<Renderer>().material.mainTexture = cross;
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = circle;
        }
        
        this.transform.parent.transform.parent.GetComponent<BoardSpecific>().turn = !player;

        steps = ++this.transform.parent.transform.parent.GetComponent<BoardSpecific>().steps;
        
        if(steps == 9)
        {
            textField.text = "Game is over. However, I don't have algorithm yet to tell who won....Sorry :(";
            btn.GetComponentInChildren<Text>().text = "Restart";
            btn.SetActive(true);
            //Debug.Log("Game is over. However, I don't have algorithm yet to tell who won....Sorry :(");
        }

    }
}
