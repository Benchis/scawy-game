using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject jumpscare;
    AudioSource source;
    
    public string sceneName;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (jumpscare.GetComponent<SpriteRenderer>().enabled == false)
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            GetComponent<Rigidbody2D>().MovePosition(mousePos);
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Finish")
        {
            
            if (sceneName != null)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        else
        {
            jumpscare.GetComponent<SpriteRenderer>().enabled = true;
            Invoke("BackToMenu", 3f);
            source.Play();
            
        }
        

    }

    void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
