using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finnish : MonoBehaviour
{
    public string sceneName;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (sceneName != null)
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }
}
