
using UnityEngine;

public class BoardSpecific : MonoBehaviour {
    public bool turn;
    public int steps;

    private void Start()
    {
        GameObject.Find("Button").SetActive(false);
    }

}
