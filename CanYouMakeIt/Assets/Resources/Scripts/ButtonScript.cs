using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public void Back()
    {
        SceneManager.LoadScene("Menu_Start");
    }

    public void Leves()
    {
        SceneManager.LoadScene("Menu_levels");
    }

    public void Shop()
    {
        SceneManager.LoadScene("Menu_Shop");
    }

    public void Launch()
    {
        SceneManager.LoadScene("Level_001");
    }

}
