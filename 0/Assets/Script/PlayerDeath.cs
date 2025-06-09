using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    // Tag do objeto que mata o jogador
    public string deadlyTag = "Deadly";

    // Método chamado quando o jogador colide com outro objeto (Collider2D)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(deadlyTag))
        {
            Die();
        }
    }

    // Método de morte do jogador
    void Die()
    {
        Debug.Log("O jogador morreu!");
        // Reinicia a cena atual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}