using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RepCodeScript : MonoBehaviour
{
    public string URL = "https://github.com/KasperOzog/Unity-Project-New";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadURL()
    {
        Application.OpenURL(URL);
    }
}
