using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class YUSHGameController : MonoBehaviour
{
    public GameObject lemon;
    public Vector2 spawnValues;
    public int lemonCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Text gameOverText;

    private bool gameOver;

    void Start ()
    {
        StartCoroutine (SpawnWaves ());
    }




    IEnumerator SpawnWaves ()
    {
        yield return new WaitForSeconds (startWait);
        while (true)
        {
            for (int i = 0; i < lemonCount; i++)
            {
                Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (lemon, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
            }
            yield return new WaitForSeconds (waveWait);

            if (gameOver)
            {
                break;
            }
        }
    }

    public void GameOver ()
        {
            gameOverText.text = "Game Over!";
            gameOver = true;
        }

}
