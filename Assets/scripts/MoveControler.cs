using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MoveControler : MonoBehaviour
{
    public bool isFinalLevel;
    public Vector3 speed;
    public Saver save;
    public int CurrentLevel;
    public KeyCode key1;
    public KeyCode key2;
    private Rigidbody rb;
    private SceneControl scenes;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        scenes = FindAnyObjectByType<SceneControl>();
        if (this.transform.CompareTag("Player")){ GameObject.Find("LvlText").GetComponent<Text>().text = "LVL " + CurrentLevel; }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(key1))
        {
            rb.velocity += speed;
        }
        else if (Input.GetKey(key2))
        {
            rb.velocity -= speed;
        }
        if (Input.GetKey(KeyCode.R))
        {
            scenes.LoadScene(CurrentLevel+1);
        }
    }
    public GameObject FinalPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("end") && this.transform.CompareTag("Player"))
        {
            if(isFinalLevel == false)
            {
                save.LevelDone[CurrentLevel] = true;
                scenes.LoadScene(CurrentLevel + 1);

            }
            else
            {
                FinalPanel.SetActive(true);
            }
        }
    }
}
