using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Switch : MonoBehaviour
{
    public GameObject room2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;    // Leaves game in editor mode
            #else
                Application.Quit()
            #endif
        }
        if (Input.GetKeyDown("2"))
        {
            this.transform.position = room2.transform.position;
        }
        else if (Input.GetKeyDown("1"))
        {
            this.transform.position = new Vector3(0,0,0);
        }
    }
}
