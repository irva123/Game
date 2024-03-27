using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    public GameObject[] stars;

    void Start() {
        // Matikan semua bintang saat game dimulai
        foreach (GameObject star in stars) {
            star.SetActive(false);
        }

        // Panggil metode ShowStar untuk menampilkan bintang sesuai dengan skor
        StartCoroutine(ShowStar());
    }

    IEnumerator ShowStar() {
        int currentScore = player.score;
        if (currentScore < 25) {
            stars[0].SetActive(true);
            yield return new WaitForSeconds(1.0f);
        }
        if (currentScore < 50) {
            stars[0].SetActive(true);
            yield return new WaitForSeconds(1.0f);
            stars[1].SetActive(true);
        } else {
            stars[0].SetActive(true);
            yield return new WaitForSeconds(1.0f);
            stars[1].SetActive(true);
            yield return new WaitForSeconds(1.0f);
            stars[2].SetActive(true);
        }

        // Selesai menampilkan bintang
        yield break;
    }
}