using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneOneAction : MonoBehaviour
{
    public Button button;
    public string mainScene;
    private void Start()
    {
        button.onClick.AddListener(OnButtonclick);
    }
    private void OnButtonclick(){
        Debug.Log("Button  is clicked and goto in Main Scene...");
        SceneManager.LoadScene(mainScene);
    }
}
