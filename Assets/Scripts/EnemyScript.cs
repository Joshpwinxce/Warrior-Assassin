using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    public float Speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    public GameObject youDie;
    public GameObject fadeOut;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Assasin");
    }

    // Update is called once per frame
    void Update()
    {
       
        
        enemyRb.AddForce((player.transform.position - transform.position).normalized * Speed);
    }

    
    

    void OnTriggerEnter()
    {
        StartCoroutine(YouDied());
    }

    IEnumerator YouDied()
    {
        youDie.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}

