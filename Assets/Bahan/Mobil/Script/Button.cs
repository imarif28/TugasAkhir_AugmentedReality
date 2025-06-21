using UnityEngine;
using UnityEngine.SceneManagement;
public class HalamanManager : MonoBehaviour
{
    public AudioSource audiobutton;
    
    public bool isEscapeToExit;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscapeToExit)
            {
                Application.Quit();
            }
            else
            {
                KembaliKeHome();
            }
        }
    }
    public void MulaiPermainan()
    {
        audiobutton.Play();
        SceneManager.LoadScene("Mobil");
        
    }
    public void KembaliKeHome()
    {
        audiobutton.Play();
        SceneManager.LoadScene("Menu");
        
    }
    public void Anggota()
    {
        audiobutton.Play();
        SceneManager.LoadScene("Member");
    }

    public void Keluar()
    {
        audiobutton.Play();
        Application.Quit();
    }

    public void Datsun()
    {
        audiobutton.Play();
        SceneManager.LoadScene("Datsun");
    }

    public void Chevrolet()
    {
        audiobutton.Play();
        SceneManager.LoadScene("Chevrolet");
    }
    
    public void Triumph()
    {
        audiobutton.Play();
        SceneManager.LoadScene("Triumph");
    }
}
