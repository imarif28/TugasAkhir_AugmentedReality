using UnityEngine;

public class ImageMove : MonoBehaviour
{
    // Array posisi X untuk perpindahan
    float[] posX = new float[] {0, -20, -40, }; // Posisi X
    int idx = 0; // Indeks posisi saat ini
    public AudioSource audiobutton;

    // Fungsi untuk tombol kiri
    public void MoveRight()
    {
        if (idx > 0)
        {
            audiobutton.Play();
            idx--; // Kurangi indeks
            UpdatePosition(); // Perbarui posisi objek
        }
    }

    // Fungsi untuk tombol kanan
    public void MoveLeft()
    {
        if (idx < posX.Length - 1)
        {
            audiobutton.Play();
            idx++; // Tambah indeks
            UpdatePosition(); // Perbarui posisi objek
        }
    }

    // Fungsi untuk memperbarui posisi berdasarkan indeks
    private void UpdatePosition()
    {
        transform.position = new Vector3(posX[idx], transform.position.y, transform.position.z);
    }
}
