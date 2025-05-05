using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject introComic;
    public GameObject puzzleGame;
    public GameObject midComic;
    public GameObject spaceInvaders;

    public ComicController introController;
    public ComicController midController;
    public PuzzleController puzzleController;

    void Start()
    {
        StartCoroutine(GameFlow());
    }

    IEnumerator GameFlow()
    {
        introComic.SetActive(true);
        yield return new WaitUntil(() => introController.IsFinished);
        introComic.SetActive(false);

        puzzleGame.SetActive(true);
        yield return new WaitUntil(() => puzzleController.IsPuzzleSolved);
        puzzleGame.SetActive(false);

        midComic.SetActive(true);
        yield return new WaitUntil(() => midController.IsFinished);
        midComic.SetActive(false);

        spaceInvaders.SetActive(true);
        // Space Invaders kendi kendini yönetebilir
    }
}
