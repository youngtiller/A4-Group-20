using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public static int SceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneNumber==0){
            StartCoroutine(ToMainMenu());
        }
    }

    IEnumerator ToMainMenu(){
        yield return new WaitForSeconds(3);
        SceneNumber=1;
        SceneManager.LoadScene(1);
;    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
