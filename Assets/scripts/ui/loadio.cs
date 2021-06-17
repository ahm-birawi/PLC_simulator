using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        SceneManager.LoadScene("IO_experiment", LoadSceneMode.Additive);
    }

}
