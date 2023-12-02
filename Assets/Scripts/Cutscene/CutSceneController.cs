using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutSceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Menetapkan callback untuk mendeteksi akhir video
        videoPlayer.loopPointReached += EndReached;

        // Memulai pemutaran video
        videoPlayer.Play();
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        // Panggil metode untuk masuk ke dalam permainan (in-game)
        LoadInGameScene();
    }

    void LoadInGameScene()
    {
        // Ganti "YourInGameScene" dengan nama scene in-game Anda
        SceneManager.LoadScene("HouseMc");
    }
}
