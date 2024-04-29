using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;
    // Start is called before the first frame update
    [ContextMenu("Increase score")]
   public void addscore()
    {
        playerscore = playerscore + 1;
        scoretext.text = playerscore.ToString();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    }
    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}
