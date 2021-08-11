using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneMotoru : MonoBehaviour
{
    static public bool isOpen;

    public GameObject Loading;

    textScript cambardak;

    private void Start()
    {
        if (isOpen == true)
        {
            StartCoroutine(waitfor());
        }
        IEnumerator waitfor()
        {
            while (isOpen == true)
            {
                yield return new WaitForSeconds(3);
            }
            yield return new WaitForSeconds(3);

        }
    }
    public void goSingle()
    {
        Loading.gameObject.SetActive(true);
        isOpen = true;
        
        SceneManager.LoadScene("Singleplayer");


    }
    public void goExit()
    {


        Application.Quit();


       
    }
    public void goMenu()
    {


        SceneManager.LoadScene("Main_Menu");


    }
}
