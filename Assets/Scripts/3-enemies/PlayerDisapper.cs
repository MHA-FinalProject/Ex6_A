using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDisapper : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            EndGame(); // Call a method to end the game
        }
    }
    void EndGame()
    {
        // You can add any additional logic here, like displaying a game over screen, restarting the level, etc.
        SceneManager.LoadScene("DestroyGameOver"); // Replace "GameOverScene" with the name of your game over scene
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
