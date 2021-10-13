using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MasterController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button1;
    public Button button2;
    public Button button3;
    public string newScene1;
    public string newScene2;
    public string newScene3;
    // Update is called once per frame
    private void Start()
    {
        button1.onClick.AddListener(OnButtonclick1);
        button2.onClick.AddListener(OnButtonclick2);
        button3.onClick.AddListener(OnButtonclick3);
    }
    private void OnButtonclick1(){
        Debug.Log("Button 1 is clicked and goto in Scene one...");
        SceneManager.LoadScene(newScene1);
    }
    private void OnButtonclick2(){
        Debug.Log("Button 2 is clicked and goto in Scene Two...");
        SceneManager.LoadScene(newScene2);
    }
    private void OnButtonclick3(){
        Debug.Log("Button 3 is clicked and goto in Scene Three...");
        SceneManager.LoadScene(newScene3);
    }

}
